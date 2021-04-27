using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEBSoLienLacDienTu.Areas.HeThongTaiLieu.Model
{
    public class MergeQues
    {
        public List<AnswerModel> LstAns { get; set; }
        public QuestionModel Question { get; set; }
    }
}