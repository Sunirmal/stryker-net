namespace Stryker.Core.Options.Inputs
{
    public class DevModeInput : SimpleStrykerInput<bool>
    {
        public override StrykerInput Type => StrykerInput.DevMode;
        public override bool DefaultValue => false;

        protected override string Description => @"Stryker automatically removes all mutations from a method if a failed mutation could not be rolled back
    Setting this flag makes stryker not remove the mutations but rather crash on failed rollbacks";

        public DevModeInput(bool? devMode)
        {
            if (devMode is { })
            {
                Value = devMode.Value;
            }
        }
    }
}
