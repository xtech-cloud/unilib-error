/********************************************************************
     Copyright (c) XTechCloud
     All rights reserved.
*********************************************************************/

namespace XTC
{
    public class Error
    {
        public int code {get; private set;}
        public string message{get; private set;}
        private static Error ok_ = new Error(0, "");

        public Error(int _code, string _message)
        {
            code = _code;
            message = _message;
        }

        public override string ToString()
        {
        	return string.Format("{0}:{1}", code, message);
        }

        public static Error OK
        {
            get
            {
                return ok_;
            }
        }

        public static Error NewNullErr(string _message, params object[] _args)
        {
            string message = string.Format(_message, _args);
            return new Error(-1, message);
        }

        public static Error NewParamErr(string _message, params object[] _args)
        {
            string message = string.Format(_message, _args);
            return new Error(-2, message);
        }

        public static Error NewAccessErr(string _message, params object[] _args)
        {
            string message = string.Format(_message, _args);
            return new Error(-3, message);
        }
    }//class
}//namespace

