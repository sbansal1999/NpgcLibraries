using System;

namespace NpgcLibraries {
    public class NpgcString {
        public static string Replace(string stringToOperate, char oldChar, char newChar) {
            if (oldChar == newChar) {
                return stringToOperate;
            }

            char[] charArray = stringToOperate.ToCharArray();

            for (int i = 0; i < charArray.Length; i++) {
                if (charArray[i] == oldChar) {
                    charArray[i] = newChar;
                }
            }

            return new string(charArray);
        }

        public static string Insert(string stringToOperate, int startIndex, string value) {
            if (startIndex < 0 || startIndex >= stringToOperate.Length) {
                throw new ArgumentOutOfRangeException(value);
            }

            char[] newArray = new char[stringToOperate.Length + value.Length];

            char[] firstPart = stringToOperate.ToCharArray(0, startIndex);
            char[] secondPart = stringToOperate.ToCharArray(startIndex, stringToOperate.Length - startIndex);


            char[] partToBeInserted = value.ToCharArray();

            int counter = 0;

            foreach (char c in firstPart) {
                newArray[counter] = c;
                counter++;
            }

            foreach (char c in partToBeInserted) {
                newArray[counter] = c;
                counter++;
            }

            foreach (char c in secondPart) {
                newArray[counter] = c;
                counter++;
            }


            return new string(newArray);
        }

        public static string ToUpper(string stringToOperate) {
            char[] newString = new char[stringToOperate.Length];

            int counter = 0;

            foreach (char c in stringToOperate) {
                if (Char.IsUpper(c)) {
                    //if char is in upper case copy it as is
                    newString[counter] = c;
                }
                else {
                    //if char is in lower case convert it to upper
                    newString[counter] = Char.ToUpper(c);
                }

                counter++;
            }

            return new string(newString);
        }

        public static string Substring(string stringToOperate, int startIndex, int lengthRequired) {
            return new string(stringToOperate.ToCharArray(startIndex, lengthRequired));
        }

        public static string Remove(string stringToOperate, int startIndex, int length) {
            char[] firstPart = stringToOperate.ToCharArray(0, startIndex);
            char[] secondPart =
                stringToOperate.ToCharArray(startIndex + length, stringToOperate.Length - startIndex - length);

            char[] newArray = new char[firstPart.Length + secondPart.Length];
            Array.Copy(firstPart, newArray, firstPart.Length);
            Array.Copy(secondPart, 0, newArray, firstPart.Length, secondPart.Length);


            return new string(newArray);
        }

        public static string Clone(string stringToOperate) {
            char[] stringArray = stringToOperate.ToCharArray();
            return new string(stringArray);
        }

        public static int Compare(string firstString, string secondString) {
            if (firstString == null || secondString == null) {
                throw new ArgumentNullException();
            }

            if (firstString.Equals(secondString)) {
                return 0;
            }

            int firstLength = firstString.Length;
            int secondLength = secondString.Length;

            if (firstLength >= secondLength) {
                //first = "hello" second = "hi"
                for (int i = 0; i < secondLength; i++) {
                    if (firstString[i] == secondString[i]) {
                        continue;
                    }

                    if (firstString[i] > secondString[i]) {
                        return 1;
                    }

                    return -1;
                }

                return 0;
            }
            else {
                //first = "hi" second = "hello"
                for (int i = 0; i < firstLength; i++) {
                    if (firstString[i] == secondString[i]) {
                        continue;
                    }

                    if (firstString[i] > secondString[i]) {
                        return 1;
                    }

                    return -1;
                }

                return 0;
            }
        }

        public static int CompareOrdinal(string firstString, string secondString) {
            if (firstString == null || secondString == null) {
                throw new ArgumentNullException();
            }

            if (firstString.Equals(secondString)) {
                return 0;
            }

            int firstLength = firstString.Length;
            int secondLength = secondString.Length;

            if (firstLength >= secondLength) {
                //first = "hello" second = "hi"
                for (int i = 0; i < secondLength; i++) {
                    if (firstString[i] == secondString[i]) {
                        continue;
                    }

                    return (int) (firstString[i] - secondString[i]);
                }

                return 0;
            }
            else {
                //first = "hi" second = "hello"
                for (int i = 0; i < firstLength; i++) {
                    if (firstString[i] == secondString[i]) {
                        continue;
                    }

                    return (int) (firstString[i] - secondString[i]);
                }

                return 0;
            }
        }

        public static string Concat(string firstString, string secondString) {
            char[] newStringArray = new char[firstString.Length + secondString.Length];
            int counter = 0;

            foreach (char c in firstString) {
                newStringArray[counter] = c;
                counter++;
            }

            foreach (char c in secondString) {
                newStringArray[counter] = c;
                counter++;
            }

            return new string(newStringArray);
        }
    }
}