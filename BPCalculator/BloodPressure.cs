using System;
using System.ComponentModel.DataAnnotations;

namespace BPCalculator
{
    // BP categories
    public enum BPCategory
    {
        [Display(Name = "Low Blood Pressure")] Low,
        [Display(Name = "Normal Blood Pressure")] Normal,
        [Display(Name = "Pre-High Blood Pressure")] PreHigh,
        [Display(Name = "High Blood Pressure")] High
    };

    public enum BPSuggestedTreatment
    {
        [Display(Name = "Eat More Salt")] Low,
        [Display(Name = "Keep up the healthy lifestyle")] Normal,
        [Display(Name = "Time to ease back on the booze and cigarettes")] PreHigh,
        [Display(Name = "Time to visit the GP for a checkup")] High
    };

    public class BloodPressure
    {
        public const int SystolicMin = 70;
        public const int SystolicMax = 190;
        public const int DiastolicMin = 40;
        public const int DiastolicMax = 100;

        public String CurrentBP;

        [Range(SystolicMin, SystolicMax, ErrorMessage = "Invalid Systolic Value")]
        public int Systolic { get; set; }                       // mmHG

        [Range(DiastolicMin, DiastolicMax, ErrorMessage = "Invalid Diastolic Value")]
        public int Diastolic { get; set; }                      // mmHG

        // calculate BP category
        public BPCategory Category
        {
            get
            {
                // implement as part of project
                if (Systolic < 90 || Diastolic < 60)
                {
                    return BPCategory.Low;
                }
                else if ((Systolic > 140 && Systolic <= 190) || Diastolic > 90)
                {
                    return BPCategory.High;
                }
                else if ((Systolic >= 90 && Systolic <= 120) && (Diastolic >= 60 && Diastolic <= 80))
                {
                    return BPCategory.Normal;
                }
                else if ((Systolic > 120 && Systolic <= 140) || (Diastolic > 80 && Diastolic <= 90))
                {
                    return BPCategory.PreHigh;
                }
                else
                {
                    throw new Exception("Out of BP Category range");
                }
            }
        }

        public BPSuggestedTreatment SuggestedTreatment
        {
            get
            {
                switch (Category)
                {
                    case BPCategory.Low:
                        return BPSuggestedTreatment.Low;
                    case BPCategory.High:
                        return BPSuggestedTreatment.High;
                    case BPCategory.Normal:
                        return BPSuggestedTreatment.Normal;
                    case BPCategory.PreHigh:
                        return BPSuggestedTreatment.PreHigh;
                    default:
                        throw new Exception("Out of BP Category range");
                }
            }
        }

    }
}
