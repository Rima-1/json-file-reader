using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Medication
    {
        public List<AceInhibitor> aceInhibitors { get; set; }
        public List<Antianginal> antianginal { get; set; }
        public List<Anticoagulant> anticoagulants { get; set; }
        public List<BetaBlocker> betaBlocker { get; set; }
        public List<Diuretic> diuretic { get; set; }
        public List<Mineral> mineral { get; set; }
    }
}
