/* Coder by KFY */
using System;
using System.Text;
using System.Security.Cryptography;

namespace LicenseKeyGenerator.Tools
{
    public class RSACrypter : IDisposable
    {
        public void Dispose()
        {

        }
        public string Decrypt(string _text)
        {
            try
            {
                var testData = Encoding.UTF8.GetBytes(_text);
                using (var rsa = new RSACryptoServiceProvider(RsaKeySize))
                {
                    try
                    {
                        var base64Encrypted = _text;
                        rsa.FromXmlString(RSAPrivateKey);
                        var resultBytes = Convert.FromBase64String(base64Encrypted);
                        var decryptedBytes = rsa.Decrypt(resultBytes, true);
                        var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                        return decryptedData.ToString();
                    }
                    finally
                    {
                        rsa.PersistKeyInCsp = false;
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("RSACrypter.Decrypt -> ", _ex);
                return _text;
            }
        }
        public string Encrypt(string _text)
        {
            try
            {
                var testData = Encoding.UTF8.GetBytes(_text);
                using (var rsa = new RSACryptoServiceProvider(RsaKeySize))
                {
                    try
                    {
                        rsa.FromXmlString(PRAPublicKey.ToString());
                        var encryptedData = rsa.Encrypt(testData, true);
                        var base64Encrypted = Convert.ToBase64String(encryptedData);
                        return base64Encrypted;
                    }
                    finally
                    {
                        rsa.PersistKeyInCsp = false;
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("RSACrypter.Encrypt -> ", _ex);
                return _text;
            }
        }
        static string PRAPublicKey = "<RSAKeyValue><Modulus>2W4PRowZcLKSj8CgOILNqoSRBmIdGtwS4bzhSgzb90zXLi/fDUvOccp9INBrhcW1eS9qGgI2BSNuXrjDejtC3rlbw6QZZ7i36KBz4TBXYsGeo9dQcF8PJgsCT9TUtniUWwhKD1jC26ffTG24tOU4xVCBYEJOsEiYK2yA0Vld1Yj7h1wTcFCrs7QK6VfSaCi6ipT1t1zJwlX5QEa1srPqvugeFHZg3A6AiO4/xgf32wtJQSt7E9T77KHvbJJWOKBDWcHaoij2gPOQs7b18TRbblrze6bYyCno2V+LaceTKBzF2lw2DmRhoyK2RBuFtBhF743pvGYuFIateXO97D0BPQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
        static string RSAPrivateKey = "<RSAKeyValue><Modulus>2W4PRowZcLKSj8CgOILNqoSRBmIdGtwS4bzhSgzb90zXLi/fDUvOccp9INBrhcW1eS9qGgI2BSNuXrjDejtC3rlbw6QZZ7i36KBz4TBXYsGeo9dQcF8PJgsCT9TUtniUWwhKD1jC26ffTG24tOU4xVCBYEJOsEiYK2yA0Vld1Yj7h1wTcFCrs7QK6VfSaCi6ipT1t1zJwlX5QEa1srPqvugeFHZg3A6AiO4/xgf32wtJQSt7E9T77KHvbJJWOKBDWcHaoij2gPOQs7b18TRbblrze6bYyCno2V+LaceTKBzF2lw2DmRhoyK2RBuFtBhF743pvGYuFIateXO97D0BPQ==</Modulus><Exponent>AQAB</Exponent><P>/XCg4QM22CeOTFBvE8IYmvt6DXL/OUt9rrktoAGZe3On4c2m4vpYhsY8s8x4uIZofbBXuXMHr99Tla+pbnDqdoBgGMgTWYze6iNisHeZCxSgaqJV0fXj0B7Op5VusgRULPkBBSivJb9Eb2xqNA8KCmy8qHTbhbgkAyMUUTcfCMc=</P><Q>26BQDnRygnKsx3viv7ZRae1NFqPZSgwI6UHc4t4z6vDLKm9kVGOuMIYICLFzKMN5oaq2QU2fEKQBNRWyURu0T5jG2bSp3ELGvvsbPg43n/A+RZn+nnVKba6p5tjYc9Yx6lwStVUT//hC9yz5LZkiIPZBqZoz1MlaL9aqsR0Sids=</Q><DP>IHD7VvI3YgHmOCSPo2LUDXqlS/VtcCMWqnfvvCyYPfI3CjNt6l4LWO0lNgq1ZUFnPLeG8ykjUcLvixiaQpXXnWWfZ2ys9WiP3D69UkNs5rs0MZIoFCE6kRhwcYkySz08nSkelU945AcQtoaVLabDLURv/cw/kWVZzsD9x8ubgF8=</DP><DQ>flN3uNjCBMZxG0zm396+dW9JJ/yWv0Cs335CzzuAIWLfeUkZLHEpgD+X32gyFQBateK7clRzad7r0tzn9D87N41o01BXY5oFN1S4FrmWxSgqqV4qVnqglPYiQ+X2mqpZi7PqDuMg3dquqf30VYX/W3ZJzoQjzAEFHv8ar0VJpIE=</DQ><InverseQ>63zHF6qTpHOxIS5LTv1tzcXg1SdFS56mYGO3QVHwrDGh2cRp5iZO8ijP2jYH4Wo65dIL8aqLphEvFZqy22vNMK1D+214Z7wZ4Xn3iM+CM93AsIxKv9SZWNrUheVGhfwhNTDS6meZ6vJqBbUmElnnLnDj34AhSgjIqgP8A1qHOS8=</InverseQ><D>pUeOgRgadpqn4nKQ2KRF5qsi+vE2IqbMC6DiuMGRrClTIR7utVK8ua8s8va75VJnIpmyU9b+bWWDjqlwnsfRizDn2o4xabD2y/S8YZ+3rbB1ASK5WNJJ16diuICWuaZrT8+7THMynHq9uYFmeMwOHZ+W2S9OVZ65Xbj7Kyh9tcUlo1LKY0f81Bop7nwSUPhtZXPpN9WVGbhOvqyGDd+BGKoJR/GD9vPAO0a4LuZ7GRlraite0tw/+UnU5O8QFeyD48pdUaTZM25+7eYOB8od3fHBxK7F+nisiz2pbR0w+VvjihmRJF4MCItlQeb8L7voapT0vaVU6130kIM4XtnB2Q==</D></RSAKeyValue>";
        static int RsaKeySize = 2048;
        }
}
