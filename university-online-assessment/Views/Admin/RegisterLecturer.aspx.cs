﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using university_online_assessment.Models;

namespace university_online_assessment.Views.Admin
{
    public partial class RegisterLecturer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void addNewLecturer()
        {
            if (Page.IsValid)
            {
                try
                {
                    // Retrieve controls
                    TextBox lectId = registerLecturerForm.FindControl("lectId") as TextBox;
                    TextBox password = registerLecturerForm.FindControl("password_confirmation") as TextBox;
                    TextBox email = registerLecturerForm.FindControl("email") as TextBox;

                    // First create the user membership
                    MembershipUser newLecturer = Membership.CreateUser(lectId.Text, password.Text, email.Text);
                    Roles.AddUserToRole(lectId.Text, "Lecturer");

                    // Create the lecturer profile
                    Lecturer_Profile lecturer = new Lecturer_Profile();
                    lecturer.Id = (Guid)newLecturer.ProviderUserKey;
                    TryUpdateModel(lecturer);

                    if (ModelState.IsValid)
                    {
                        // Connect to database to add new staff profile
                        using (OnlineAssessmentDBEntities db = new OnlineAssessmentDBEntities())
                        {
                            // Add the new staff and save it
                            db.Lecturer_Profile.Add(lecturer);
                            db.SaveChanges();

                            // Set the text to new staff ID
                            newLecturerID.Text = lectId.Text;

                            // Show success label & hide failure label
                            alertSuccess.Visible = true;
                            alertFailure.Visible = false;
                        }
                    }
                }
                catch (MembershipCreateUserException ex)
                {
                    // Match exception code with status code from MembershipCreateStatus class
                    switch (ex.StatusCode)
                    {
                        case MembershipCreateStatus.DuplicateUserName:
                            alertFailureMsg.Text = "There already exists a user with this username.";
                            break;
                        case MembershipCreateStatus.DuplicateEmail:
                            alertFailureMsg.Text = "There already exists a user with this email address.";
                            break;
                        case MembershipCreateStatus.InvalidEmail:
                            alertFailureMsg.Text = "There email address you provided in invalid.";
                            break;
                        case MembershipCreateStatus.InvalidPassword:
                            alertFailureMsg.Text = "The password you provided is invalid. It must be seven characters long and have at least one non-alphanumeric character.";
                            break;
                        default:
                            alertFailureMsg.Text = "There was an unknown error; the user account was NOT created.";
                            break;
                    }

                    // Show failure message
                    alertSuccess.Visible = false;
                    alertFailure.Visible = true;
                }
                catch (Exception ex)
                {
                    // Show failure message
                    alertFailureMsg.Text = "Oops! There was a problem occurred when registering the new lecturer.";
                    alertSuccess.Visible = false;
                    alertFailure.Visible = true;
                }
            }
        }
    }
}