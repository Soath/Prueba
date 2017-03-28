public class clsBeBdiSOCpSociedades : ICloneable {

	private string mBUKRS = '';
	private string mBUTXT = '';

	public String BUKRS {
		get {
			return mBUKRS;
		}
		set {
			mBUKRS = value;
		}
	}

	public String BUTXT {
		get {
			return mBUTXT;
		}
		set {
			mBUTXT = value;
		}
	}

	BdiSOCpSociedades(){
	}

	BdiSOCpSociedades(){ref string BUKRS, string BUTXT)
		mBUKRS = BUKRS;
		mBUTXT = BUTXT;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
