using ContactManager.Models;
using ContactManager.Services;
using System.Web.Http;

namespace ContactManager.Controllers
{
	public class ContactController : ApiController
	{
		private ContactRepository contactRepository;
		public ContactController()
		{
			this.contactRepository = new ContactRepository();
		}

		public Contact[] Get()
		{
			return contactRepository.GetAllContacts();
		}
	}

}
