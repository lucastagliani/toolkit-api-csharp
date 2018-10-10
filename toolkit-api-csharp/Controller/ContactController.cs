using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using toolkit_api_csharp.Model;
using toolkit_api_csharp.Services;

namespace toolkit_api_csharp.Controller
{
    public class ContactController : ApiController
    {
        private ContactRepository repository;

        public ContactController()
        {
            repository = new ContactRepository();
        }

        public Contact[] Get()
        {
            return repository.GetList();
        }

        public HttpResponseMessage Post(Contact contact)
        {
            this.repository.SaveContact(contact);

            var response = Request.CreateResponse(HttpStatusCode.Created, contact);

            return response;
        }
    }
}
