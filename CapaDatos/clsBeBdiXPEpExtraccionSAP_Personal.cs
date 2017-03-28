public class clsBeBdiXPEpExtraccionSAP_Personal : ICloneable {

	private string mPERNR = '';
	private string mNachn = '';
	private string mName2 = '';
	private string mVorna = '';
	private string mDNI = '';
	private string mWERKS = '';
	private string mPersg = '';
	private string mKOSTL = '';

	public String PERNR {
		get {
			return mPERNR;
		}
		set {
			mPERNR = value;
		}
	}

	public String Nachn {
		get {
			return mNachn;
		}
		set {
			mNachn = value;
		}
	}

	public String Name2 {
		get {
			return mName2;
		}
		set {
			mName2 = value;
		}
	}

	public String Vorna {
		get {
			return mVorna;
		}
		set {
			mVorna = value;
		}
	}

	public String DNI {
		get {
			return mDNI;
		}
		set {
			mDNI = value;
		}
	}

	public String WERKS {
		get {
			return mWERKS;
		}
		set {
			mWERKS = value;
		}
	}

	public String Persg {
		get {
			return mPersg;
		}
		set {
			mPersg = value;
		}
	}

	public String KOSTL {
		get {
			return mKOSTL;
		}
		set {
			mKOSTL = value;
		}
	}

	BdiXPEpExtraccionSAP_Personal(){
	}

	BdiXPEpExtraccionSAP_Personal(){ref string PERNR, string Nachn, string Name2, string Vorna, string DNI, string WERKS, string Persg, string KOSTL)
		mPERNR = PERNR;
		mNachn = Nachn;
		mName2 = Name2;
		mVorna = Vorna;
		mDNI = DNI;
		mWERKS = WERKS;
		mPersg = Persg;
		mKOSTL = KOSTL;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
