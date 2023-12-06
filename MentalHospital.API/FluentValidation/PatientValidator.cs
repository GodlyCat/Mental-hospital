namespace MentalHospital.API.FluentValidation
{
    public class PatientValidator : AbstractValidator<PatientViewModel>
    {
        public PatientValidator() 
        {
            RuleFor(p => p.FirstName).Length(2, 50);
            RuleFor(p => p.ChamberNumber).ExclusiveBetween(0, 1000);
            RuleFor(p => p.Diagnosis).Length(1, 100);
            RuleFor(p => p.Therapy).Length(1, 150);
            RuleFor(p => p.RegisteredAt)
                .Must(dt => DateTime.TryParse(dt.ToString(), out dt));
            RuleFor(p => p.UnregisteredAt)
                .Must(dt => DateTime.TryParse(dt.ToString(), out dt));

        }
    }
}
