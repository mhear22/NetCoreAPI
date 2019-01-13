using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models.Payments
{
	public class PaymentModel
	{
		public TokenModel Token;
		public string PlanId;
	}

	public class TokenModel
	{
		public CardModel card;
		public string client_ip;
		public int created;
		public bool livemode;
		public bool used;
		public string email;
		public string id;
		public string @object;
		public string type;
	}

	public class CardModel
	{
		public string brand;
		public string country;
		public string cvc_check;
		public string funding;
		public string id;
		public string last4;
		public string name;
		public string @object;
		public int exp_month;
		public int exp_year;
		public object metadata;
		public object address_city;
		public object address_country;
		public object address_line1;
		public object address_line1_check;
		public object address_line2;
		public object address_state;
		public object address_zip;
		public object address_zip_check;
		public object dynamic_last4;
		public object tokenization_method;
	}
}
