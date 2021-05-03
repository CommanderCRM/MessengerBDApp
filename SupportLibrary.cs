using System;

namespace SupportLibrary
{
	public class BaseExceptionProperties
	{

		protected bool mHasException;

		public bool HasException
		{
			get
			{
				return mHasException;
			}
		}
		protected Exception mLastException;

		public Exception LastException
		{
			get
			{
				return mLastException;
			}
		}

		public string LastExceptionMessage => mLastException.Message;

		public bool IsSuccessFul => !mHasException;
	}
}