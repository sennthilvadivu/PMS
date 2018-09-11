using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.Serialization;

namespace PMS.Core.Common
{
    /// <summary>
    /// PMSResponse object
    /// </summary>
    /// <typeparam name="T">Type T</typeparam>
    [DataContract(Name = "PMSResponse{0}")]
    public class PMSResponse<T>
    {
        /// <summary>
        /// service custom code
        /// </summary>
        [DataMember]
        public int Code { get; set; }

        /// <summary>
        /// service custom message
        /// </summary>
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        /// response object
        /// </summary>
        [DataMember]
        public T Data { get; set; }
    }

    /// <summary>
    /// SimplifyResponse object
    /// </summary>
    public class PMSResponse
    {
        /// <summary>
        /// service custom code
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// service custom message
        /// </summary>
        public string Message { get; set; }
    }

    public interface IEnumAttribute<out T>
    {
        /// <summary>
        /// Generic type Value
        /// </summary>
        T Value { get; }
    }
    public sealed class HttpStatusAttribute : Attribute, IEnumAttribute<HttpStatusCode>
    {
        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="value">HttpStatusCode value</param>
        public HttpStatusAttribute(HttpStatusCode value)
        {
            Value = value;
        }

        /// <summary>
        /// Gets HttpStatusCode value
        /// </summary>
        public HttpStatusCode Value { get; }
    }

    public enum ResponseCodes
    {
        [HttpStatus(HttpStatusCode.OK)]
        [Description("Success")]
        Ok = 2000,

        [HttpStatus(HttpStatusCode.OK)]
        [Description("Venture created successfully")]
        VentureCreated = 2001,
    }

    public class EnumManager : SingletonBase<EnumManager>
    {
        private EnumManager()
        { }

        /// <summary>
        /// Get description of the enum members
        /// </summary>
        /// <typeparam name="T">Enum type</typeparam>
        /// <param name="enumData">Enum member data</param>
        /// <returns>Enum member description</returns>
        public string GetDescription<T>(T enumData)
        {
            FieldInfo fi = enumData.GetType().GetField(enumData.ToString());
            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : enumData.ToString();
        }

        /// <summary>
        /// Gets custom attribute value of the enum member
        /// </summary>
        /// <typeparam name="T">Enum type</typeparam>
        /// <typeparam name="TR">Attribute type</typeparam>
        /// <typeparam name="TA"></typeparam>
        /// <param name="enumData">Enum Member</param>
        /// <returns></returns>
        public TR GetAttributeValue<T, TA, TR>(T enumData)
        {
            TR attributeValue = default(TR);

            var fi = enumData.GetType().GetField(enumData.ToString());

            var attributes = fi?.GetCustomAttributes(typeof(TA), false) as TA[];

            if (attributes != null && attributes.Length > 0)
            {
                var attribute = attributes[0] as IEnumAttribute<TR>;

                if (attribute != null)
                {
                    attributeValue = attribute.Value;
                }
            }
            return attributeValue;
        }
    }

    public abstract class SingletonBase<T> where T : class
    {
        #region Members

        /// <summary>
        /// Static instance. Needs to use lambda expression
        /// to construct an instance (since constructor is private)
        /// </summary>
        private static readonly Lazy<T> SInstance = new Lazy<T>(CreateInstanceOfT);

        #endregion

        #region Properties

        /// <summary>
        /// Gets the instance of this singleton
        /// </summary>
        public static T Instance => SInstance.Value;

        #endregion

        #region Methods

        /// <summary>
        /// Creates an instance of T via reflection since T's constructor is expected to be private
        /// </summary>
        /// <returns></returns>
        private static T CreateInstanceOfT()
        {
            return Activator.CreateInstance(typeof(T), true) as T;
        }

        #endregion
    }

    public class ServiceResponse<T> : SingletonBase<ServiceResponse<T>>
    {
        /// <summary>
        /// ServiceResponse constructor
        /// </summary>
        private ServiceResponse()
        {
        }

        /// <summary>
        /// Builds the service response
        /// </summary>
        /// <param name="code">ResponseCodes</param>
        /// <param name="data">Object of type T</param>
        /// <returns>SimplifyResponse object</returns>
        public PMSResponse<T> BuildResponse(ResponseCodes code, T data)
        {
            return new PMSResponse<T>
            {
                Code = (int)code,
                Message = EnumManager.Instance.GetDescription(code),
                Data = data
            };           
        }

        public PMSResponse<T> BuildErrorResponse(ResponseCodes code)
        {
            return new PMSResponse<T>
            {
                Code = (int)code,
                Message = EnumManager.Instance.GetDescription(code)
            };
                    }
    }

    /// <summary>
    /// Manages service response
    /// </summary>
    public class ServiceResponse : SingletonBase<ServiceResponse>
    {
        /// <summary>
        /// ServiceResponse constructor
        /// </summary>
        private ServiceResponse()
        { }

        /// <summary>
        /// Builds the service response
        /// </summary>
        /// <param name="code">ResponseCodes</param>
        /// <returns>SimplifyResponse object</returns>
        public PMSResponse BuildResponse(ResponseCodes code)
        {
            return new PMSResponse
            {
                Code = (int)code,
                Message = EnumManager.Instance.GetDescription(code)
            };
                   }
    }
}
