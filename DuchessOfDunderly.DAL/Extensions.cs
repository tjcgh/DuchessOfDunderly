using System;
namespace DuchessOfDunderly.DAL
{
    public static class Extensions
    {
        public static bool EqualsExactly(this double source, double target)
        {
            double difference = Math.Abs(source * .001);
            if (Math.Abs(source - target) <= difference)
                return true;
            return false;
        }
        public static bool NotEqual(this double source, double target)
        {
            return !source.EqualsExactly(target);
        }

    }
}