using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcCv.Models;

namespace MvcCv.Sınıf
{
    public class Class1
    {
        public IEnumerable<TblAbout> hakkımda { get; set; }
        public IEnumerable<TblExperience> deneyimler { get; set; }
        public IEnumerable<TblEducation> eğitim { get; set; }
        public IEnumerable<TblCertificates> sertifika { get; set; }
        public IEnumerable<TblInterests> hobi { get; set; }
        public IEnumerable<TblSkills> yetenek { get; set; }

    }
}