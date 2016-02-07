namespace DataAccess.Models
{
    public class TemplateModel
    {
        #region History
        public string Chief_Complaint { get; set; }
        public string HPI { get; set; }
        public string PFSH { get; set; }

        public MedicalProblems Constitutional { get; set; }
        public MedicalProblems Eyes { get; set; }
        public MedicalProblems Throat { get; set; }
        public MedicalProblems Cardiovascular { get; set; }
        public MedicalProblems Respiratory { get; set; }
        public MedicalProblems Gastrointestinal { get; set; }
        public MedicalProblems Genitourinary { get; set; }
        public MedicalProblems Muscular { get; set; }
        public MedicalProblems Integumentary { get; set; }
        public MedicalProblems Neurological { get; set; }
        public MedicalProblems Endocrine { get; set; }
        public MedicalProblems Hemotologic { get; set; }
        public MedicalProblems Allergies { get; set; }

        #endregion
        #region UnitsOfMeasure
        public class BloodPressure {
            public double systolic { get; set; } // 
            public double diastolic { get; set; }
            public override string ToString()
            {
                return $"{systolic}/{diastolic}";
            }
        }
        #endregion
        #region PSYCHIATRIC SPECIALTY EXAMINATION
        public bool IsExamined { get; set; }
        public BloodPressure Blood_Pressure_Sitting { get; set; } 
        public BloodPressure Blood_Pressure_Standing { get; set; }
        public double Supine { get; set; }
        public double Temp { get; set; }
        public double Pulse_Rate { get; set; }
        public double Pulse_Regularity { get; set; }
        public double Respiration { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string General_Appearance { get; set; }
        public bool Assessment { get; set; }
        public bool Examination_Of_Gait { get; set; }
        public string Musculoskeletal { get; set; }
        public bool Rate { get; set; }
        public bool Volume { get; set; }
        public bool Articulation { get; set; }
        public bool Coherence { get; set; }
        public bool Spontaneity { get; set; }
        public string Speech_Notes { get; set; }
        public bool Associations { get; set; }
        public bool Processes { get; set; }
        public bool Abstraction { get; set; }
        public bool Computation { get; set; }
        public string Description_Of_Associations { get; set; }
        public string Description_Of_Psychotic_Thoughts { get; set; }
        public bool IsSuicidalIdeation { get; set; }
        public bool IsHomicidalIdeation { get; set; }
        public bool IsViolentIdeation { get; set; }
        public bool IsIntact { get; set; }
        //public bool isInadequate { get; set; }
        public string Description_Of_Patient_Judgment { get; set; }
        public string Orientation { get; set; }
        public string Memory { get; set; }
        public string Concentration { get; set; }
        public string Language { get; set; }
        public string Mood { get; set; }
        public string Other { get; set; }

        #endregion

        #region MEDICAL DECISION MAKING
        //public string Axis { get; set; }
        public string Rule_Outs { get; set; }
        public string Formulation { get; set; }
        public string Tests_Reviewed { get; set; }
        public bool IsNew { get; set; }
        public bool IsImproving { get; set; }
        public string Intervention { get; set; }
        public string Medication { get; set; }
        public string Consultation { get; set; }
        public string Treatment_Other { get; set; }
        public bool IsStable { get; set; }
        public bool IsComplicated { get; set; }
        public bool IsIndependent { get; set; }
        public bool Interface_With_Management { get; set; }
        public bool IsGreaterThanFifty { get; set; }
        public string GreaterThanFifty_Content { get; set; }

        #endregion

        public TemplateModel()
        {
            Constitutional = new MedicalProblems();
            Eyes = new MedicalProblems();
            Throat = new MedicalProblems();
            Cardiovascular = new MedicalProblems();
            Respiratory = new MedicalProblems();
            Gastrointestinal = new MedicalProblems();
            Genitourinary = new MedicalProblems();
            Muscular = new MedicalProblems();
            Integumentary = new MedicalProblems();
            Neurological = new MedicalProblems();
            Endocrine = new MedicalProblems();
            Hemotologic = new MedicalProblems();
            Allergies = new MedicalProblems();
        }
    }
}
