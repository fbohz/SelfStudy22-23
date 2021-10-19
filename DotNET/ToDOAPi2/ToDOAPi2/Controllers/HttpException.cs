using System;
using System.Net;
using System.Runtime.Serialization;

namespace ToDOAPi2.Controllers {
    [Serializable]
    internal class HttpException : Exception {
        private HttpStatusCode notFound;

        public HttpException() {
        }

        public HttpException(HttpStatusCode notFound) {
            this.notFound = notFound;
        }

        public HttpException(string message) : base(message) {
        }

        public HttpException(string message, Exception innerException) : base(message, innerException) {
        }

        protected HttpException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}