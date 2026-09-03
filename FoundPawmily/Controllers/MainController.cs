using FoundPawmily.Models;
using FoundPawmily.Models.Context;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace FoundPawmily.Controllers
{
    public class MainController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Found Pawmily | Home";
            return View();
        }

        public ActionResult Dogs()
        {
            ViewBag.Title = "Found Pawmily | Dogs & Puppies";
            return View();
        }

        public ActionResult Cats()
        {
            ViewBag.Title = "Found Pawmily | Cats & Kittens";
            return View();
        }

        public ActionResult Volunteer()
        {
            ViewBag.Title = "Found Pawmily | Volunteer Now";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "Found Pawmily | About Us";
            return View();
        }

        public ActionResult PetProfile()
        {
            ViewBag.Title = "Found Pawmily | Pet Profile";
            return View();
        }

        public ActionResult AdoptForm()
        {
            ViewBag.Title = "Found Pawmily | Adoption Form";
            return View();
        }

        public ActionResult VolunteerForm()
        {
            ViewBag.Title = "Found Pawmily | Volunteer Form";
            return View();
        }

        public ActionResult SignInDashboard()
        {
            return View();
        }

        public ActionResult SignUpDashboard()
        {
            return View();
        }

        public ActionResult Dashboard()
        {

            //check for user not signed in
            if (Session["LoggedInUser"] == null)
                return RedirectToAction("SignInDashboard");

            //stores name
            var id = Session["LoggedInUser"];
            using (var db = new FoundPawmilyContext())
            {
                var user = db.tbl_users.Where(x => x.userID == (int)id).FirstOrDefault();
                ViewBag.userID = user.userID;
                ViewBag.FirstName = user.firstName;
                ViewBag.LastName = user.lastName;
                ViewBag.pfp = user.imagePath;

                if(user.isArchived == 1)
                    return RedirectToAction("SignInDashboard");

                var currentUserID = (int)Session["LoggedInUser"];
                var logForm = new tblLogsModel()
                {
                    action = "Navigated to Dashboard",
                    accessDateTime = DateTime.Now,
                    userID = currentUserID
                };
                db.tbl_logs.Add(logForm);
                db.SaveChanges();

            }

            return View();
        }

        public ActionResult TableVolunteers()
        {
            if (Session["LoggedInUser"] == null)
                return RedirectToAction("SignInDashboard");

            //stores name
            var id = Session["LoggedInUser"];
            using (var db = new FoundPawmilyContext())
            {
                var user = db.tbl_users.Where(x => x.userID == (int)id).FirstOrDefault();
                ViewBag.userID = user.userID;
                ViewBag.FirstName = user.firstName;
                ViewBag.LastName = user.lastName;
                ViewBag.pfp = user.imagePath;

                if (user.isArchived == 1)
                    return RedirectToAction("SignInDashboard");

                var currentUserID = (int)Session["LoggedInUser"];
                var logForm = new tblLogsModel()
                {
                    action = "Navigated to Table Volunteers",
                    accessDateTime = DateTime.Now,
                    userID = currentUserID
                };
                db.tbl_logs.Add(logForm);
                db.SaveChanges();

            }

            return View();
        }

        public ActionResult TablePets()
        {
            if (Session["LoggedInUser"] == null)
                return RedirectToAction("SignInDashboard");

            //stores name
            var id = Session["LoggedInUser"];
            using (var db = new FoundPawmilyContext())
            {
                var user = db.tbl_users.Where(x => x.userID == (int)id).FirstOrDefault();
                ViewBag.userID = user.userID;
                ViewBag.FirstName = user.firstName;
                ViewBag.LastName = user.lastName;
                ViewBag.pfp = user.imagePath;

                if (user.isArchived == 1)
                    return RedirectToAction("SignInDashboard");

                var currentUserID = (int)Session["LoggedInUser"];
                var logForm = new tblLogsModel()
                {
                    action = "Navigated to Table Pets",
                    accessDateTime = DateTime.Now,
                    userID = currentUserID
                };
                db.tbl_logs.Add(logForm);
                db.SaveChanges();

            }

            return View();
        }

        public ActionResult TableAdoptions()
        {
            if (Session["LoggedInUser"] == null)
                return RedirectToAction("SignInDashboard");

            //stores name
            var id = Session["LoggedInUser"];
            using (var db = new FoundPawmilyContext())
            {
                var user = db.tbl_users.Where(x => x.userID == (int)id).FirstOrDefault();
                ViewBag.userID = user.userID;
                ViewBag.FirstName = user.firstName;
                ViewBag.LastName = user.lastName;
                ViewBag.pfp = user.imagePath;

                if (user.isArchived == 1)
                    return RedirectToAction("SignInDashboard");

                var currentUserID = (int)Session["LoggedInUser"];
                var logForm = new tblLogsModel()
                {
                    action = "Navigated to Table Adoptions",
                    accessDateTime = DateTime.Now,
                    userID = currentUserID
                };
                db.tbl_logs.Add(logForm);
                db.SaveChanges();

            }

            return View();
        }

        public ActionResult TableUsers()
        {
            if (Session["LoggedInUser"] == null)
                return RedirectToAction("SignInDashboard");

            //stores name
            var id = Session["LoggedInUser"];
            using (var db = new FoundPawmilyContext())
            {
                var user = db.tbl_users.Where(x => x.userID == (int)id).FirstOrDefault();
                ViewBag.userID = user.userID;
                ViewBag.FirstName = user.firstName;
                ViewBag.LastName = user.lastName;
                ViewBag.pfp = user.imagePath;

                if (user.isArchived == 1)
                    return RedirectToAction("SignInDashboard");

                var currentUserID = (int)Session["LoggedInUser"];
                var logForm = new tblLogsModel()
                {
                    action = "Navigated to Table Users",
                    accessDateTime = DateTime.Now,
                    userID = currentUserID
                };
                db.tbl_logs.Add(logForm);
                db.SaveChanges();

            }

            return View();
        }

        public ActionResult TableLogs()
        {
            if (Session["LoggedInUser"] == null)
                return RedirectToAction("SignInDashboard");

            //stores name
            var id = Session["LoggedInUser"];
            using (var db = new FoundPawmilyContext())
            {
                var user = db.tbl_users.Where(x => x.userID == (int)id).FirstOrDefault();
                ViewBag.userID = user.userID;
                ViewBag.FirstName = user.firstName;
                ViewBag.LastName = user.lastName;
                ViewBag.pfp = user.imagePath;

                if (user.isArchived == 1)
                    return RedirectToAction("SignInDashboard");

                var currentUserID = (int)Session["LoggedInUser"];
                var logForm = new tblLogsModel()
                {
                    action = "Navigated to Table Logs",
                    accessDateTime = DateTime.Now,
                    userID = currentUserID
                };
                db.tbl_logs.Add(logForm);
                db.SaveChanges();

            }

            return View();
        }

        public ActionResult Logout()
        {

            using (var db = new FoundPawmilyContext())
            {
                var currentUserID = (int)Session["LoggedInUser"];
                var logForm = new tblLogsModel()
                {
                    action = "Signed out",
                    accessDateTime = DateTime.Now,
                    userID = currentUserID
                };
                db.tbl_logs.Add(logForm);
                db.SaveChanges();
            }

                Session.Remove("LoggedInUser");
                Session.Remove("CurrentUserRole");
            if (Session["LoggedInUser"] == null)
                return RedirectToAction("SignInDashboard");

            return View();
        }

        public JsonResult GetPets(string type)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var petsData = db.tbl_pets.Where(x => x.isArchived == 0).Where(x => x.petType == type).ToList();
                    return Json(petsData, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        public JsonResult GetPetProfile(int id)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var petData = db.tbl_pets.Where(x => x.petID == id).FirstOrDefault();
                    return Json(petData, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        public JsonResult GetAdoption(int id)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {

                    var adoptData = (from a in db.tbl_adoptions
                                  join p in db.tbl_pets on a.petID equals p.petID
                                  where a.adoptionID == id
                                  select new
                                  {
                                      a.adoptionID,
                                      a.firstName,
                                      a.middleInitial,
                                      a.lastName,
                                      a.gender,
                                      a.emailAdd,
                                      a.phoneNum,
                                      a.birthDate,
                                      a.houseNum,
                                      a.street,
                                      a.brgy,
                                      a.city,
                                      a.province,
                                      a.zip,
                                      a.residenceType,
                                      a.residenceStatus,
                                      a.hasOwnedPets,
                                      a.currentPets,
                                      a.isArchived,
                                      a.petID,
                                      a.createdAt,
                                      a.updatedAt,
                                      petName = p.name
                                  }).FirstOrDefault();


                    return Json(adoptData, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        public JsonResult GetVolunteer(int id)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {

                    var volunteerData = db.tbl_volunteers.Where(x => x.volunteerID == id).FirstOrDefault();
                    return Json(volunteerData, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        public JsonResult GetUser(int id)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {

                    var userData = db.tbl_users.Where(x => x.userID == id).FirstOrDefault();
                    return Json(userData, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }


        public JsonResult GetProfile()
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var id = (int) Session["LoggedInUser"];
                    var profileData = db.tbl_users.Where(x => x.userID == id).FirstOrDefault();
                    return Json(profileData, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }





        //UPDATE FUNCTIONS
        public void UpdatePetData(tblPetsModel petData)
        {
            try
            {
                    using (var db = new FoundPawmilyContext())
                    {

                        var getData = db.tbl_pets.Where(x => x.petID == petData.petID).FirstOrDefault();

                        if (!string.IsNullOrEmpty(petData.imagePath))
                        {
                            string uploadPath = Server.MapPath("../Content/images/NewUploads/");
                            if (!Directory.Exists(uploadPath))
                                Directory.CreateDirectory(uploadPath);

                            var base64Data = petData.imagePath.Substring(petData.imagePath.IndexOf(",") + 1);
                            byte[] bytes = Convert.FromBase64String(base64Data);

                            string fileName = Guid.NewGuid() + ".png";
                            string filePath = Path.Combine(uploadPath, fileName);

                            System.IO.File.WriteAllBytes(filePath, bytes);

                            getData.imagePath = "../Content/images/NewUploads/" + fileName;
                        }
                        
                        getData.name = petData.name;
                        getData.petType = petData.petType;
                        getData.birthDate = petData.birthDate;
                        getData.gender = petData.gender;
                        getData.breed = petData.breed;
                        getData.size = petData.size;
                        getData.location = petData.location;
                        getData.shortDesc = petData.shortDesc;
                        getData.isSpayedNeutered = petData.isSpayedNeutered;
                        getData.isVaccinated = petData.isVaccinated;
                        getData.isDewormed = petData.isDewormed;
                        getData.updatedAt = DateTime.Now;


                        var currentUserID = (int)Session["LoggedInUser"];
                        var logForm = new tblLogsModel()
                        {
                            action = "Updated Table Pets - #" + petData.petID,
                            accessDateTime = DateTime.Now,
                            userID = currentUserID
                        };
                        db.tbl_logs.Add(logForm);
                        db.SaveChanges();

                    }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        public void UpdateAdoptData(tblAdoptionsModel adoptData)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {

                    var getData = db.tbl_adoptions.Where(x => x.adoptionID == adoptData.adoptionID).FirstOrDefault();

                    getData.firstName = adoptData.firstName;
                    getData.middleInitial = adoptData.middleInitial;
                    getData.lastName = adoptData.lastName;
                    getData.gender = adoptData.gender;
                    getData.emailAdd = adoptData.emailAdd;
                    getData.phoneNum = adoptData.phoneNum;
                    getData.birthDate = adoptData.birthDate;
                    getData.houseNum = adoptData.houseNum;
                    getData.street = adoptData.street;
                    getData.brgy = adoptData.brgy;
                    getData.city = adoptData.city;
                    getData.province = adoptData.province;
                    getData.zip = adoptData.zip;
                    getData.residenceType = adoptData.residenceType;
                    getData.residenceStatus = adoptData.residenceStatus;
                    getData.hasOwnedPets = adoptData.hasOwnedPets;
                    getData.currentPets = adoptData.currentPets;
                    getData.petID = adoptData.petID;
                    getData.updatedAt = DateTime.Now;

                    var currentUserID = (int)Session["LoggedInUser"];
                    var logForm = new tblLogsModel()
                    {
                        action = "Updated Table Adoptions - #" + adoptData.adoptionID,
                        accessDateTime = DateTime.Now,
                        userID = currentUserID
                    };
                    db.tbl_logs.Add(logForm);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        public void UpdateVolunteerData(tblVolunteersModel volunteerData)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {

                    var getData = db.tbl_volunteers.Where(x => x.volunteerID == volunteerData.volunteerID).FirstOrDefault();

                    getData.firstName = volunteerData.firstName;
                    getData.middleInitial = volunteerData.middleInitial;
                    getData.lastName = volunteerData.lastName;
                    getData.gender = volunteerData.gender;
                    getData.emailAdd = volunteerData.emailAdd;
                    getData.phoneNum = volunteerData.phoneNum;
                    getData.birthDate = volunteerData.birthDate;
                    getData.houseNum = volunteerData.houseNum;
                    getData.street = volunteerData.street;
                    getData.brgy = volunteerData.brgy;
                    getData.city = volunteerData.city;
                    getData.province = volunteerData.province;
                    getData.zip = volunteerData.zip;
                    getData.shelter = volunteerData.shelter;
                    getData.volunteerDate = volunteerData.volunteerDate;
                    getData.timeSlot = volunteerData.timeSlot;
                    getData.updatedAt = DateTime.Now;

                    var currentUserID = (int)Session["LoggedInUser"];
                    var logForm = new tblLogsModel()
                    {
                        action = "Updated Table Volunteers - #" + volunteerData.volunteerID,
                        accessDateTime = DateTime.Now,
                        userID = currentUserID
                    };
                    db.tbl_logs.Add(logForm);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        public JsonResult UpdateUserData(UpdateUserPass userData)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {

                    var getData = db.tbl_users.Where(x => x.userID == userData.userID).FirstOrDefault();

                    if (!string.IsNullOrEmpty(userData.imagePath))
                    {
                        string uploadPath = Server.MapPath("../Content/images/UserProfiles/");
                        if (!Directory.Exists(uploadPath))
                            Directory.CreateDirectory(uploadPath);

                        var base64Data = userData.imagePath.Substring(userData.imagePath.IndexOf(",") + 1);
                        byte[] bytes = Convert.FromBase64String(base64Data);

                        string fileName = Guid.NewGuid() + ".png";
                        string filePath = Path.Combine(uploadPath, fileName);

                        System.IO.File.WriteAllBytes(filePath, bytes);

                        userData.imagePath = "../Content/images/UserProfiles/" + fileName;
                    }
                    getData.role = userData.role;
                    getData.updatedAt = DateTime.Now;

                    var currentUserID = (int)Session["LoggedInUser"];
                    var logForm = new tblLogsModel()
                    {
                        action = "Changed the role of #" + userData.userID,
                        accessDateTime = DateTime.Now,
                        userID = currentUserID
                    };
                    db.tbl_logs.Add(logForm);
                    db.SaveChanges();
                    return Json(new { success = true });
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        public JsonResult UpdateProfile(UpdateUserPass userData)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {

                    var getData = db.tbl_users.Where(x => x.userID == userData.userID).FirstOrDefault();

                    if (!string.IsNullOrEmpty(userData.imagePath))
                    {
                        string uploadPath = Server.MapPath("../Content/images/UserProfiles/");
                        if (!Directory.Exists(uploadPath))
                            Directory.CreateDirectory(uploadPath);

                        var base64Data = userData.imagePath.Substring(userData.imagePath.IndexOf(",") + 1);
                        byte[] bytes = Convert.FromBase64String(base64Data);

                        string fileName = Guid.NewGuid() + ".png";
                        string filePath = Path.Combine(uploadPath, fileName);

                        System.IO.File.WriteAllBytes(filePath, bytes);

                        userData.imagePath = "../Content/images/UserProfiles/" + fileName;
                        getData.imagePath = userData.imagePath;
                    }

                    getData.firstName = userData.firstName;
                    getData.lastName = userData.lastName;
                    getData.email = userData.email;

                    
                    if (!string.IsNullOrEmpty(userData.newPassword))
                    {
                        bool validPassword = BCrypt.Net.BCrypt.Verify(userData.password, getData.password);
                        if (!validPassword)
                        {
                            return Json(new { success = false, message = "Changes not saved. Old password does not match." });
                        }

                        getData.password = BCrypt.Net.BCrypt.HashPassword(userData.newPassword);
                    }

                    getData.updatedAt = DateTime.Now;

                    var currentUserID = (int)Session["LoggedInUser"];
                    var logForm = new tblLogsModel()
                    {
                        action = "Updated their profile info - #" + userData.userID,
                        accessDateTime = DateTime.Now,
                        userID = currentUserID
                    };
                    db.tbl_logs.Add(logForm);
                    db.SaveChanges();

                    return Json(new { success = true });
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }








        //Original file upload image
        //public JsonResult InsertPetData()
        //{
        //    try
        //    {
        //        if (Request.Files.Count == 0)
        //            return Json(new { Message = "No file received." });

        //        HttpPostedFileBase file = Request.Files[0];

        //        if (file != null && file.ContentLength > 0)
        //        {

        //            using (var db = new FoundPawmilyContext())
        //            {
        //                string uploadPath = Server.MapPath("~/Content/Uploads/");
        //                if (!Directory.Exists(uploadPath))
        //                    Directory.CreateDirectory(uploadPath);

        //                string fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
        //                string filePath = Path.Combine(uploadPath, fileName);
        //                file.SaveAs(filePath);

        //                var newPetData = new tblPetsModel()
        //                {
        //                    imagePath = "~/Content/Uploads/",
        //                    insertPetData.createdAt = DateTime.Now,
        //                    insertPetData.updatedAt = DateTime.Now
        //                };

        //                db.tbl_pets.Add(newPetData);
        //                db.SaveChanges();

        //                return Json(new { Message = "File uploaded successfully!", FilePath = "/Content/Uploads" + fileName });
        //            }
        //        }

        //        return Json(new { Message = "Upload failed." });

        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
        //    }
        //}


        //LOGIN
        public JsonResult LoginSession(tblUsersModel loginData)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var getData = db.tbl_users.Where(x => x.email == loginData.email).FirstOrDefault();
                    if (getData == null)
                    {
                        return Json(new { success = false, message = "Check your email or password." });
                    }

                    if (getData.isArchived == 1)
                    {
                        return Json(new { success = false, message = "This account is inactive and cannot log in." });
                    }

                    bool validPassword = BCrypt.Net.BCrypt.Verify(loginData.password, getData.password);
                    if (!validPassword)
                    {
                        return Json(new { success = false, message = "Check your email or password." });
                    }

                    Session["LoggedInUser"] = getData.userID;
                    Session["CurrentUserRole"] = getData.role;
                    var userRole = Session["CurrentUserRole"];
                    if (userRole != null)
                    { 
                        return Json(new { success = true, role = userRole.ToString() });
                    }

                    var currentUserID = (int)Session["LoggedInUser"];
                    var logForm = new tblLogsModel()
                    {
                        action = "Signed in",
                        accessDateTime = DateTime.Now,
                        userID = currentUserID
                    };

                    db.tbl_logs.Add(logForm);
                    db.SaveChanges();

                    return Json(new
                    {
                        success = true,
                        userID = getData.userID,
                        role = getData.role,
                        name = getData.firstName,
                        pfp = getData.imagePath
                    });
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }


        public void PassAdoptData(tblAdoptionsModel adoptData)
        {
            try
            {
                using(var db = new FoundPawmilyContext())
                {
                    adoptData.createdAt = DateTime.Now;
                    adoptData.updatedAt = DateTime.Now;
                    db.tbl_adoptions.Add(adoptData);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        //Insert User (tbl_users)
        public JsonResult InsertUserData(tblUsersModel signUpData)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {

                    var existing = db.tbl_users.FirstOrDefault(x => x.email == signUpData.email);
                    if (existing != null)
                    {
                        return Json(new { success = false, message = "Email already in use." });
                    }

                    if (!string.IsNullOrEmpty(signUpData.imagePath))
                    {
                        string uploadPath = Server.MapPath("../Content/images/UserProfiles/");
                        if (!Directory.Exists(uploadPath))
                            Directory.CreateDirectory(uploadPath);

                        var base64Data = signUpData.imagePath.Substring(signUpData.imagePath.IndexOf(",") + 1);
                        byte[] bytes = Convert.FromBase64String(base64Data);

                        string fileName = Guid.NewGuid() + ".png";
                        string filePath = Path.Combine(uploadPath, fileName);

                        System.IO.File.WriteAllBytes(filePath, bytes);

                        signUpData.imagePath = "../Content/images/UserProfiles/" + fileName;
                    }
                    else
                    {
                        signUpData.imagePath = "../Content/images/defaultpfp.jpg";
                    }

                    signUpData.password = BCrypt.Net.BCrypt.HashPassword(signUpData.password);
                    signUpData.isArchived = 0;
                    signUpData.createdAt = DateTime.Now;
                    signUpData.updatedAt = DateTime.Now;
                    db.tbl_users.Add(signUpData);

                    db.SaveChanges();

                    return Json(new { success = true });
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        //Volunteer Insert
        public void PassVolunteerData(tblVolunteersModel volunteerData)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    volunteerData.createdAt = DateTime.Now;
                    volunteerData.updatedAt = DateTime.Now;
                    db.tbl_volunteers.Add(volunteerData);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        //PASSING OF DATA (tbl_pets)
        public void InsertPetData(tblPetsModel petData)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {

                    if (!string.IsNullOrEmpty(petData.imagePath))
                    {
                        string uploadPath = Server.MapPath("../Content/images/NewUploads/");
                        if (!Directory.Exists(uploadPath))
                            Directory.CreateDirectory(uploadPath);

                        var base64Data = petData.imagePath.Substring(petData.imagePath.IndexOf(",") + 1);
                        byte[] bytes = Convert.FromBase64String(base64Data);

                        string fileName = Guid.NewGuid() + ".png";
                        string filePath = Path.Combine(uploadPath, fileName);

                        System.IO.File.WriteAllBytes(filePath, bytes);

                        petData.imagePath = "../Content/images/NewUploads/" + fileName;
                    }
                    else
                    {
                        petData.imagePath = "../Content/images/image_placeholder.png";
                    }

                    var petForm = new tblPetsModel()
                    {
                        name = petData.name,
                        petType = petData.petType,
                        birthDate = petData.birthDate,
                        gender = petData.gender,
                        breed = petData.breed,
                        size = petData.size,
                        location = petData.location,
                        shortDesc = petData.shortDesc,
                        isSpayedNeutered = petData.isSpayedNeutered,
                        isVaccinated = petData.isVaccinated,
                        isDewormed = petData.isDewormed,
                        imagePath = petData.imagePath,
                        isArchived = 0,
                        createdAt = DateTime.Now,
                        updatedAt = DateTime.Now
                    };

                    db.tbl_pets.Add(petForm);

                    var currentUserID = (int)Session["LoggedInUser"];
                    var logForm = new tblLogsModel()
                    {
                        action = "Added a new pet profile",
                        accessDateTime = DateTime.Now,
                        userID = currentUserID
                    };
                    db.tbl_logs.Add(logForm);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        //PASSING OF DATA (tbl_adoptions - admin side)
        public void InsertAdoptData(tblAdoptionsModel adoptData)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    adoptData.isArchived = 0;
                    adoptData.createdAt = DateTime.Now;
                    adoptData.updatedAt = DateTime.Now;
                    db.tbl_adoptions.Add(adoptData);

                    var currentUserID = (int)Session["LoggedInUser"];
                    var logForm = new tblLogsModel()
                    {
                        action = "Added to Table Adoptions",
                        accessDateTime = DateTime.Now,
                        userID = currentUserID
                    };
                    db.tbl_logs.Add(logForm);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        //PASSING OF DATA (tbl_volunteers - admin side)
        public void InsertVolunteerData(tblVolunteersModel volunteerData)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    volunteerData.isArchived = 0;
                    volunteerData.createdAt = DateTime.Now;
                    volunteerData.updatedAt = DateTime.Now;
                    db.tbl_volunteers.Add(volunteerData);

                    var currentUserID = (int)Session["LoggedInUser"];
                    var logForm = new tblLogsModel()
                    {
                        action = "Added to Table Volunteers",
                        accessDateTime = DateTime.Now,
                        userID = currentUserID
                    };
                    db.tbl_logs.Add(logForm);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }





        //TABLE LOGS
        public JsonResult GetLogs()
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var logsData = (from a in db.tbl_logs
                                           join p in db.tbl_users on a.userID equals p.userID
                                           select new
                                           {
                                               a.logID,
                                               a.action,
                                               a.accessDateTime,
                                               a.userID,
                                               userFirstName = p.firstName,
                                               userLastName = p.lastName
                                           }).ToList();

                    return Json(logsData, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }




        //TABLE PETS

        public JsonResult GetNotArchivedDataPets()
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var notArchivedData = db.tbl_pets.ToList();
                    return Json(notArchivedData, JsonRequestBehavior.AllowGet);
                }
            } catch(Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        public JsonResult GetNotReallyArchivedDataPets()
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var notArchivedData = db.tbl_pets.Where(x => x.isArchived == 0).ToList();
                    return Json(notArchivedData, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        public JsonResult ToArchivedFuncPets(int PetID)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var archivedData = db.tbl_pets.Where(z => z.petID == PetID).FirstOrDefault();
                    if(archivedData.isArchived == 1)
                    {
                        archivedData.isArchived = 0;
                        var currentUserID = (int)Session["LoggedInUser"];
                        var logForm = new tblLogsModel()
                        {
                            action = "Unarchived Pet - #" + PetID,
                            accessDateTime = DateTime.Now,
                            userID = currentUserID
                        };
                        db.tbl_logs.Add(logForm);

                    } else
                    {
                        archivedData.isArchived = 1;
                        var currentUserID = (int)Session["LoggedInUser"];
                        var logForm = new tblLogsModel()
                        {
                            action = "Archived Pet - #" + PetID,
                            accessDateTime = DateTime.Now,
                            userID = currentUserID
                        };
                        db.tbl_logs.Add(logForm);

                    }
                    archivedData.updatedAt = DateTime.Now;
                    db.SaveChanges();
                    var notArchivedData = db.tbl_pets.ToList();
                    return Json(notArchivedData, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }







        //TABLE ADOPTIONS

        public JsonResult GetNotArchivedDataAdoptions()
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var notArchivedData = (from a in db.tbl_adoptions
                                     join p in db.tbl_pets on a.petID equals p.petID
                                     select new
                                     {
                                         a.adoptionID,
                                         a.firstName,
                                         a.middleInitial,
                                         a.lastName,
                                         a.gender,
                                         a.emailAdd,
                                         a.phoneNum,
                                         a.birthDate,
                                         a.houseNum,
                                         a.street,
                                         a.brgy,
                                         a.city,
                                         a.province,
                                         a.zip,
                                         a.residenceType,
                                         a.residenceStatus,
                                         a.hasOwnedPets,
                                         a.currentPets,
                                         a.isArchived,
                                         a.petID,
                                         a.createdAt,
                                         a.updatedAt,
                                         petName = p.name
                                     }).ToList();


                    return Json(notArchivedData, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        public JsonResult ToArchivedFuncAdoptions(int AdoptID)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var archivedData = db.tbl_adoptions.Where(z => z.adoptionID == AdoptID).FirstOrDefault();
                    if (archivedData.isArchived == 1)
                    {
                        archivedData.isArchived = 0;
                        var currentUserID = (int)Session["LoggedInUser"];
                        var logForm = new tblLogsModel()
                        {
                            action = "Unarchived Adoption - #" + AdoptID,
                            accessDateTime = DateTime.Now,
                            userID = currentUserID
                        };
                        db.tbl_logs.Add(logForm);

                    }
                    else
                    {
                        archivedData.isArchived = 1;
                        var currentUserID = (int)Session["LoggedInUser"];
                        var logForm = new tblLogsModel()
                        {
                            action = "Archived Adoption - #" + AdoptID,
                            accessDateTime = DateTime.Now,
                            userID = currentUserID
                        };
                        db.tbl_logs.Add(logForm);

                    }
                    archivedData.updatedAt = DateTime.Now;
                    db.SaveChanges();
                    var dataSet = db.tbl_adoptions.ToList();
                    return Json(dataSet, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }


        //TABLE VOLUNTEERS

        public JsonResult GetNotArchivedDataVolunteers()
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var notArchivedData = db.tbl_volunteers.ToList();
                    return Json(notArchivedData, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        public JsonResult ToArchivedFuncVolunteers(int VolunteerID)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var archivedData = db.tbl_volunteers.Where(z => z.volunteerID == VolunteerID).FirstOrDefault();
                    if (archivedData.isArchived == 1)
                    {
                        archivedData.isArchived = 0;
                        var currentUserID = (int)Session["LoggedInUser"];
                        var logForm = new tblLogsModel()
                        {
                            action = "Unarchived Volunteer - #" + VolunteerID,
                            accessDateTime = DateTime.Now,
                            userID = currentUserID
                        };
                        db.tbl_logs.Add(logForm);

                    }
                    else
                    {
                        archivedData.isArchived = 1;
                        var currentUserID = (int)Session["LoggedInUser"];
                        var logForm = new tblLogsModel()
                        {
                            action = "Archived Volunteer - #" + VolunteerID,
                            accessDateTime = DateTime.Now,
                            userID = currentUserID
                        };
                        db.tbl_logs.Add(logForm);

                    }
                    archivedData.updatedAt = DateTime.Now;
                    db.SaveChanges();
                    var notArchivedData = db.tbl_volunteers.ToList();
                    return Json(notArchivedData, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }



        //TABLE USERS
        public JsonResult GetNotArchivedDataUsers()
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var notArchivedData = db.tbl_users.ToList();
                    return Json(notArchivedData, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }

        public JsonResult ToArchivedFuncUsers(int UserID)
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var archivedData = db.tbl_users.Where(z => z.userID == UserID).FirstOrDefault();
                    if (archivedData.isArchived == 1)
                    {
                        archivedData.isArchived = 0;
                        var currentUserID = (int)Session["LoggedInUser"];
                        var logForm = new tblLogsModel()
                        {
                            action = "Activated User Account - #" + UserID,
                            accessDateTime = DateTime.Now,
                            userID = currentUserID
                        };
                        db.tbl_logs.Add(logForm);

                    }
                    else
                    {
                        archivedData.isArchived = 1;
                        var currentUserID = (int)Session["LoggedInUser"];
                        var logForm = new tblLogsModel()
                        {
                            action = "Deactivated User Account - #" + UserID,
                            accessDateTime = DateTime.Now,
                            userID = currentUserID
                        };
                        db.tbl_logs.Add(logForm);

                    }
                    archivedData.updatedAt = DateTime.Now;
                    db.SaveChanges();
                    var notArchivedData = db.tbl_users.ToList();
                    return Json(notArchivedData, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error : {ex.Message}, {ex.InnerException}, {ex.StackTrace}");
            }
        }





        //CHARTS
        public JsonResult ChartPetsDataFunc()
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var petData = db.tbl_pets
                                    .Where(p => p.isArchived == 0)
                                    .GroupBy(p => p.petType)
                                    .Select(g => new
                                    {
                                        PetType = g.Key,
                                        Count = g.Count()
                                    })
                                    .ToList();

                    var labels = petData.Select(p => p.PetType).ToList();
                    var data = petData.Select(p => p.Count).ToList();

                    return Json(new { labels = labels, data = data }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error: {ex.Message}");
            }
        }


        public JsonResult ChartVolunteersDataFunc()
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var volunteers = db.tbl_volunteers
                                       .Where(v => v.isArchived == 0)
                                       .ToList();

                    var groupedData = volunteers
                        .GroupBy(v => new { Month = v.volunteerDate.Month, v.gender })
                        .Select(g => new
                        {
                            Month = g.Key.Month,
                            Gender = g.Key.gender,
                            Count = g.Count()
                        })
                        .ToList();

                    var monthLabels = new[] { "January", "February", "March", "April", "May", "June",
                                      "July", "August", "September", "October", "November", "December" };

                   
                    var genders = groupedData.Select(g => g.Gender).Distinct().ToList();
                    var dataSets = new List<List<int>>();

                    foreach (var gender in genders)
                    {
                        var counts = new List<int>();
                        for (int m = 1; m <= 12; m++)
                        {
                            var monthData = groupedData.FirstOrDefault(x => x.Month == m && x.Gender == gender);
                            counts.Add(monthData != null ? monthData.Count : 0);
                        }
                        dataSets.Add(counts);
                    }

                    return Json(new
                    {
                        labels = monthLabels,
                        series = genders,
                        data = dataSets
                    }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"The application encountered an error: {ex.Message}");
            }
        }

        public JsonResult ChartAdoptionsDataFunc()
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var adoptionData = db.tbl_adoptions
                        .Join(db.tbl_pets,
                              a => a.petID,
                              p => p.petID,
                              (a, p) => new { a.province, p.petType })
                        .ToList();

                    var provinces = adoptionData.Select(x => x.province).Distinct().ToList();
                    var petTypes = adoptionData.Select(x => x.petType).Distinct().ToList();

                    var dataList = new List<List<int>>();
                    foreach (var petType in petTypes)
                    {
                        var counts = new List<int>();
                        foreach (var province in provinces)
                        {
                            int count = adoptionData
                                .Where(x => x.province == province && x.petType == petType)
                                .Count();
                            counts.Add(count);
                        }
                        dataList.Add(counts);
                    }

                    return Json(new
                    {
                        labels = provinces,
                        series = petTypes,
                        data = dataList
                    }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Error: {ex.Message}");
            }
        }


        public JsonResult DashboardCounts()
        {
            try
            {
                using (var db = new FoundPawmilyContext())
                {
                    var totalAdoptions = db.tbl_adoptions.Count(a => a.isArchived == 0);
                    var totalVolunteers = db.tbl_volunteers.Count(v => v.isArchived == 0);
                    var petsForAdoption = db.tbl_pets.Count(p => p.isArchived == 0);
                    var totalEmployees = db.tbl_users.Count(e => e.isArchived == 0);

                    return Json(new
                    {
                        totalAdoptions,
                        totalVolunteers,
                        petsForAdoption,
                        totalEmployees
                    }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Error fetching dashboard counts: {ex.Message}");
            }
        }



        //PDF MAKE
        public JsonResult GetAdoptionReportData()
        {
            using (var db = new FoundPawmilyContext())
            {
                var data = (from a in db.tbl_adoptions
                            join p in db.tbl_pets on a.petID equals p.petID
                            where a.isArchived == 0
                            select new
                            {
                                name = a.firstName + " " + a.lastName,
                                email = a.emailAdd,
                                phone = a.phoneNum,
                                address = a.houseNum + ", " + a.street + ", " + a.brgy + ", " + a.city + ", " + a.province + ", " + a.zip,
                                petName = p.name + "(" + p.petType + ")"
                            })
                            .ToList();

                var currentUserID = (int)Session["LoggedInUser"];
                var logForm = new tblLogsModel()
                {
                    action = "Printed adoption report",
                    accessDateTime = DateTime.Now,
                    userID = currentUserID
                };
                db.tbl_logs.Add(logForm);
                db.SaveChanges();

                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult GetVolunteerReportData()
        {
            using (var db = new FoundPawmilyContext())
            {
                var rawData = (from v in db.tbl_volunteers
                            where v.isArchived == 0
                            select new
                            {
                                v.firstName,
                                v.lastName,
                                v.emailAdd,
                                v.phoneNum,
                                v.volunteerDate,
                                v.timeSlot,
                                v.shelter
                            }).ToList();

                var data = rawData.Select(v => new
                {
                    name = v.firstName + " " + v.lastName,
                    email = v.emailAdd,
                    phone = v.phoneNum,
                    volunteerDate = v.volunteerDate.ToString("MMM dd, yyyy"),
                    timeSlot = v.timeSlot,
                    shelter = v.shelter
                }).ToList();

                var currentUserID = (int)Session["LoggedInUser"];
                var logForm = new tblLogsModel()
                {
                    action = "Printed volunteer report",
                    accessDateTime = DateTime.Now,
                    userID = currentUserID
                };
                db.tbl_logs.Add(logForm);
                db.SaveChanges();

                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }

        public JsonResult GetPetReportData()
        {
            using (var db = new FoundPawmilyContext())
            {
                var data = (from p in db.tbl_pets
                               where p.isArchived == 0
                               select new
                               {
                                   petName = p.name,
                                   type = p.petType,
                                   breed = p.breed,
                                   gender = p.gender,
                                   location = p.location
                               }).ToList();

                var currentUserID = (int)Session["LoggedInUser"];
                var logForm = new tblLogsModel()
                {
                    action = "Printed pets for adoption report",
                    accessDateTime = DateTime.Now,
                    userID = currentUserID
                };
                db.tbl_logs.Add(logForm);
                db.SaveChanges();

                return Json(data, JsonRequestBehavior.AllowGet);
            }
        }














        //public string GetUserInformation()
        //{
        //    return "User information retrieved successfully.";
        //}

        //public string ConcatenateInformation(string firstname, string telephone)
        //{
        //    return firstname + " " + telephone; ;
        //}

        // For collectively receiving data as a single object
        //public string JSONInformation(UserInformation userInfo)
        //{
        //    return userInfo.Name + " " + userInfo.Number;
        //}

        // Returns a model and not individually; always insert try and catch block for error handling
        //public JsonResult JSONReturn(UserInformation userInfo)
        //{
        //    try
        //    {
        //        userInfo.Name = $"The name of the user is {userInfo.Name}";
        //        userInfo.Number = $"The contact number of the user is {userInfo.Number}";
        //        return Json(userInfo, JsonRequestBehavior.AllowGet);
        //    }
        //    catch(Exception ex)
        //    {
        //        throw new ArgumentException("An error occurred during the process of JSON return.");
        //    }
        //}
    }
}