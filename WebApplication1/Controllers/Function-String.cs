using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Function_String : ControllerBase
    {
        [HttpGet]
        public string Check_String_Condition(string req)
        {
            //Regex reg_check_length = new Regex(@"^(?!.*_$)[A-Za-z][A-Za-z0-9_]{4,25}$");
            Regex reg_check_range = new Regex(@"^.{4,25}$");
            Regex reg_check_first_text = new Regex(@"^[A-Za-z][A-Za-z\s\S]*$");
            Regex reg_check_text_num_symbol = new Regex(@"^[A-Za-z0-9_]+$");
            Regex reg_check_end_underscore = new Regex(@"^(?!.*_$)");
            string respone = "";
            Match match_range = reg_check_range.Match(req);
            if (!match_range.Success) return "ความยาวต้องอยู่ระหว่าง 4 ถึง 25 ตัวอักษร";
            Match match_first_text = reg_check_first_text.Match(req);
            if (!match_first_text.Success) return "ต้องเริ่มต้นคำด้วยตัวอักษรเท่านั้น";
            Match match_text_num_symbol = reg_check_text_num_symbol.Match(req);
            if (!match_text_num_symbol.Success) return "ต้องประกอบไปด้วย ตัวอักษร ตัวเลข และ _ เท่านั้น";
            Match match_text_end_underscore = reg_check_end_underscore.Match(req);
            if (!match_text_end_underscore.Success) return "ห้ามลงท้ายด้วย _";

            respone = "Pass";

            return respone;
        }
    }
}
