namespace DesingPatternOOP_;
using DesingPatternOOP_.src.solid.S;

public class Userservice
{
 
   public void RegiterUser(User user)
    {
        EmailSender emailSender = new EmailSender();
        emailSender.sendEmail(user.Email, "Welcome to our application!");

    }
}
