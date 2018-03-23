   var data = [];

   function Call()
   {
    var username = document.New.register_name.value;
    var password = document.New.register_password.value;
    var phone = document.New.phone.value;
    var email = document.New.register_email.value;
    var confpass = document.New.con_register_password.value;
    var confemail = document.New.con_register_email.value;
    var gender = document.New.register_gender.value;
    var country = document.New.register_country.value;

    if (grecaptcha.getResponse() == "")
    {
        alert("Please Verify Captcha");
        return false;
    }

    if(password!=confpass)
    { alert("MisMatch Password"); return false; }

    if (email != confemail)
    { alert("MisMatch Email"); return false; }

    var v = prompt("Enter OTP");
    if (v == 1111)
    {
        
        try
        {
            var data = { "UserName": username, "Password": password, "Phone": phone, "Email": email, "Gender": gender, "Country": country };
            var obj = JSON.parse(JSON.stringify(data));
            window.data.push(obj);
            alert("Account Create Successful");
            open("loginPage.html");
        }
        catch (e)
        {
            alert("Error: " + e.description);
        }
        
    }
    else
    {
        alert("Enter Correct OTP");
        v = prompt("Enter OTP");
    }
   }

   function Call1()
   {

    var username = document.Forget.register_name.value;
    var phone = document.Forget.phone.value;
    var email = document.Forget.register_email.value;
    var confemail = document.Forget.con_register_email.value;
    var password = "";
    for (var d in window.data)
    {
        try
        {
            var user = JSON.stringify(d);
            if (username == user.UserName && phone == user.Phone && email == user.Email)
            password = user.Password;
        }
        catch (e)
        {
            alert("Error: " + e.description);
        }
       
    }

    if (email != confemail)
    { alert("MisMatch Email"); return false; }

    if (grecaptcha.getResponse() == "")
    {
        alert("Please Verify Captcha");
        return false;
    }

    var v = prompt("Enter OTP");
    if (v == 1111)
    {
        alert("Your Password is "+12345678);

    }
    else
    {
        alert("Enter Correct OTP");
        v = prompt("Enter OTP");
    }
   }

   function validateform()
   {
    if (grecaptcha.getResponse() == "")
    {
        alert("Please Verify Captcha");
        return false;
    }

    var name = document.myhello.username.value;
    var password = document.myhello.pass.value;

    if (name == "Nitesh" || password == 12345678)
    {
        alert("Login Successfull");
        open("HomePage.html");

    }
    else
    {
        alert("Enter Correct UserName and Password");
    }
   }
