namespace Bookstore.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Bookstore.Areas.Identity;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;

    public class UserController : Controller
    {
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private IPasswordHasher<IdentityUser> _passwordHasher;

        public UserController(
            UserManager<IdentityUser> userManager, 
            RoleManager<IdentityRole> roleManager, 
            IPasswordHasher<IdentityUser> passwordHasher)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _passwordHasher = passwordHasher;
        }

        // GET: UserController
        public ActionResult Index()
        {
            var users = _userManager.Users;
            return View(users);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            var roles = _roleManager.Roles;
            var userModel = new UserModel();
            userModel.Roles = GetSelectListRoles(roles);
            return View(userModel);
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(UserModel user)
        {
            if (ModelState.IsValid)
            {
                IdentityUser appUser = new IdentityUser
                {
                    UserName = user.Name,
                    Email = user.Email,
                    EmailConfirmed = true
                };

                // istoto sto i gore
                //IdentityUser appUser = new IdentityUser();
                //appUser.UserName = user.Name;
                //appUser.Email = user.Email;
                //appUser.EmailConfirmed = true;

                IdentityResult result = await _userManager.CreateAsync(appUser, user.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(appUser, user.RoleName);
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach(IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(user);
        }

        // GET: UserController/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            IdentityUser user = await _userManager.FindByIdAsync(id);
            var roles = _roleManager.Roles;

            if(user != null)
            {
                // var getUserRoles = await _userManager.GetRolesAsync(user); // get every role for specific user
                var userModel = new UserModel
                {
                    Id = user.Id,
                    Email = user.Email,
                    Roles = GetSelectListRoles(roles)
                };
                return View(userModel);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, string email, string password, string RoleName)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        #region Helper Methods

        private IQueryable<SelectListItem> GetSelectListRoles(IQueryable<IdentityRole> roles)
        {
            var selectList = new List<SelectListItem>();
            selectList.Add(new SelectListItem
            {
                Value = "0",
                Text = "Select role..."
            });
            foreach (var item in roles)
            {
                selectList.Add(new SelectListItem
                {
                    Value = item.Id,
                    Text = item.Name
                });
            }

            return selectList.AsQueryable();
        }

        #endregion
    }
}
