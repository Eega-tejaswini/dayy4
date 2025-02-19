function loginAlert() {
        alert("Login successful!");
        document.getElementById("timetable-btn").style.display = "inline-block"; // Show timetable button
        return false;
        }

        function registerUser() {
            let name = document.getElementById("registerName").value;
            let email = document.getElementById("registerEmail").value;
            let password = document.getElementById("registerPassword").value;
            let confirmPassword = document.getElementById("confirmPassword").value;

            if (password !== confirmPassword) {
                alert("Password incorrect");
                return false;
            }

            alert( "! Registration successful.");
            return false;
        }

        function showTimetable() 
        {
    
                alert("Redirecting to TimeTable Page...");
                window.location.href = "timetable.html";
           
        }

