﻿<%@ Page Title="Assessment by Student" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentAssessmentsList.aspx.cs" Inherits="university_online_assessment.Views.Lecturer.StudentAssessmentsList" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <section id="studAssessListSection" style="min-height: 100vh">
        <div class="container">
            <h2 class="text-center pt-4">Assessments List for
                <br />
                Samuel Wong Kim Foong - 18WMR12048</h2>
            <hr />

            <%--Back to View List link--%>
            <asp:HyperLink runat="server" CssClass="btn btn-block btn-outline-primary" NavigateUrl="/lecturer/list" Text="Back to View List" />

            <%--Search Bar for assessments--%>
            <div class="form-inline mt-2">
                <label for="assessSearchBox" class="mr-2">Search:</label>
                <input type="text" id="assessSearchBox" class="form-control" />
            </div>

            <%--Table for assessments list--%>
            <table class="table">
                <thead class="thead-dark">
                    <tr>
                        <th>Assessment No.</th>
                        <th>Name</th>
                        <th>Subject</th>
                        <th>Type</th>
                        <th>Grade</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>1</td>
                        <td>Chapter 2 Web Application Development</td>
                        <td>BAIT2113 Web Application Development</td>
                        <td>MCQ</td>
                        <td>A</td>
                    </tr>
                    <tr>
                        <td>2</td>
                        <td>Chapter 3 Computer Networks</td>
                        <td>BAIT2164 Computer Networks</td>
                        <td>Written</td>
                        <td>A</td>
                    </tr>
                    <tr>
                        <td>3</td>
                        <td>Chapter 1C Agile Software Development</td>
                        <td>BAIT3343 Agile Software Development</td>
                        <td>Written</td>
                        <td>A</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </section>
</asp:Content>