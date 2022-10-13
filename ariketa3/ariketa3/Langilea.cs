using ariketa3;
using System;

/// <summary>
/// Summary description for Class1
/// </summary>

namespace ariketa3
{
	public class Langilea : Kontaktua
	{
		public float Soldata { get; set; }
		public string SegurtasunSoziala { get; set; }

		public override string email
		{
			get => base.email;
			set
			{
				//if (value.Substring((value.Length))-8 == '@uni.eus')
				if(value.Length<10 || value.Substring(value.Length-8) == "@uni.eus")
				{
					base.email = value;
				}
				else
				{
					Exception ex = new Exception("@uni.eus izan behar da");
				}
			}
		}
		public override string Gorde()
		{

		}
	}
}

