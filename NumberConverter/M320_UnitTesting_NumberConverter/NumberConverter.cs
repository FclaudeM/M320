
namespace NumberConverter {
    /// <summary>
    /// Zur Verfügung gestellt von Peter Gisler, GIBZ
    /// </summary>
    public class NumberConverter {

        StringConverter _stringConverter;

        public NumberConverter(StringConverter stringConverter = null) {
            _stringConverter = stringConverter;
        }

        public int RoundUp(float value) {
            if (value < 0 || (int)value == value)
            {
                return (int)value + 1;
            }
            return (int)value;
        }

        public int RoundDown(float value) {
            return (int)value;
        }


        public int RoundToPowerOfTen(float value, int precisionExponent = 1) {
            
            return ;
        }

    }
}
