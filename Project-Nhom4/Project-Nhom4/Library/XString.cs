using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace Project_Nhom4.Library
{
    public class XString
    {
        public static string str_MetaTitle(string s)
        {
            String[][] symbols = {
                new String[] { "[áàảãạấâầậẫẩăặắằẳẵ]", "a"},
                new String[] { "[đ]", "d"},
                new String[] { "[éèẻẹẽêếểềệễ]", "e"},
                new String[] { "[íìĩỉị]", "i"},
                new String[] { "[òóỏọõôốồộổỗơởỡớờợ]", "o"},
                new String[] { "[úùủụũưứừửựũ]", "u"},
                new String[] { "[ýỳỵỷỹ]", "y"},
                new String[] { "[\\s'\";,]", "-"}
            };
            s = s.ToLower();
            foreach(var ss in symbols)
            {
                s = Regex.Replace(s, ss[0], ss[1]);
                
            }
            return s;
        }
    }
}