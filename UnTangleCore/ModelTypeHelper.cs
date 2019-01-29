namespace UnTangle.Core
{
    public abstract class ModelTypeHelper
    {
        /// <summary>
        /// Returns a string representation of the model type.
        /// </summary>
        /// <param name="typeId">Type ID specified in the @type parameter of a block.</param>
        /// <returns>String</returns>
        public static string ParseModelType(int typeId)
        {
            switch (typeId)
            {
                case 0:
                    return ("FX");
                case 1:
                case 3:
                    return ("Amplifier");
                case 2:
                case 4:
                    return ("Cabinet");
                case 5:
                    return ("Impulse Response");
                case 6:
                    return ("Looper");
                case 7:
                    return ("Delay/Reverb");
                default:
                    return ("Unknown");
            }
        }
    };
}
