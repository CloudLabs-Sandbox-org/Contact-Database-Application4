using CRUD_application_2.Models;
using System.Linq;
using System.Web.Mvc;
 
namespace CRUD_application_2.Controllers
{
    public class UserController : Controller
    {
        public static System.Collections.Generic.List<User> userlist = new System.Collections.Generic.List<User>();
        // GET: User
        public ActionResult Index()
        {
            // Implement the Index method here
            userlist.GetEnumerator();
            return View(userlist);
        }
 
        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            // return the user with the specified ID
            // If no user is found with the provided ID, return HttpNotFoundResult
            // If successful, return the Details view
            userlist.GetEnumerator();
            var user = userlist.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }
 
        // GET: User/Create
        public ActionResult Create()
        {
            //Implement the Create method here
            // add the user to the userlist
            return View("Create");
        }
 
        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            // Implement the Create method (POST) here
            if (user == null)
            {
                return HttpNotFound();
            }
            userlist.Add(user);
            return RedirectToAction("Index");
        }
 
        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            // This method is responsible for displaying the view to edit an existing user with the specified ID.
            // It retrieves the user from the userlist based on the provided ID and passes it to the Edit view.
            // If no user is found with the provided ID, it returns a HttpNotFoundResult.
            // If successful, it returns the Edit view.
            userlist.GetEnumerator();
            var user = userlist.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View("Edit", user);
        }
 
        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            // This method is responsible for handling the HTTP POST request to update an existing user with the specified ID.
            // It receives user input from the form submission and updates the corresponding user's information in the userlist.
            // If successful, it redirects to the Index action to display the updated list of users.
            // If no user is found with the provided ID, it returns a HttpNotFoundResult.
            // If an error occurs during the process, it returns the Edit view to display any validation errors.
            userlist.GetEnumerator();
            var userToUpdate = userlist.FirstOrDefault(x => x.Id == id);
            if (userToUpdate == null)
            {
                return HttpNotFound();
            }
            userToUpdate.Name = user.Name;
            userToUpdate.Email = user.Email;
            return RedirectToAction("Index");
        }
 
        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            // Delete the user with the specified ID
            // If no user is found with the provided ID, return HttpNotFoundResult
            // If successful, return the Index view
            var userToDelete = userlist.FirstOrDefault(x => x.Id == id);
            if (userToDelete == null)
            {
                return HttpNotFound();
            }
            return View("Delete", userToDelete);

        }
 
        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            // Implement the Delete method (POST) here
            var userToDelete = userlist.FirstOrDefault(x => x.Id == id);
            if (userToDelete == null)
            {
                return HttpNotFound();
            }
            userlist.Remove(userToDelete);
            return RedirectToAction("Index");
        }


        // GET: search
        // This method is responsible for displaying the search view and can have query parameters to search for users based on specific criteria.
        public ActionResult Search(string name)
        {
            // Implement the Search method here
            // It retrieves the user from the userlist based on the provided name and passes it to the Search view.
            // If no user is found with the provided name, it returns a HttpNotFoundResult.
            // If successful, it returns the Search view.
            userlist.GetEnumerator();
            var user = userlist.FirstOrDefault(x => x.Name == name);
            if (user == null)
            {
                return View("Search");
            }
            return View("Search", user);
        }
    }
}
