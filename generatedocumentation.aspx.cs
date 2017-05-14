﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VSDocParser;


public partial class generatedocumentation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            file.Text = @"C:\Projects\dotNinja\scripts\Ninja-vsdoc.js";
            documentation.Text = @"C:\Projects\dotNinja\documentation\";
            //file.Text = @"C:\Users\Daiz\Desktop\Projects\NinJa\scripts\Ninja-vsdoc.js";
            //documentation.Text = @"C:\Users\Daiz\Desktop\Projects\NinJa\documentation";
        }
    }


    public void Generate(object o, EventArgs e)
    {
        Parser.ParseFile(file.Text, documentation.Text);
        StringBuilder sb = new StringBuilder();
        foreach (string s in Parser.Errors)
        {
            sb.Append(s + "<br />");
        }

        errors.Text = sb.ToString();
    }
}