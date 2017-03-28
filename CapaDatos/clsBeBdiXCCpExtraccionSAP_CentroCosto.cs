public class clsBeBdiXCCpExtraccionSAP_CentroCosto : ICloneable {

	private string mKOSTL = '';
	private string mKTEXT = '';
	private string mKLTXT = '';
	private string mMCDS3 = '';

	public String KOSTL {
		get {
			return mKOSTL;
		}
		set {
			mKOSTL = value;
		}
	}

	public String KTEXT {
		get {
			return mKTEXT;
		}
		set {
			mKTEXT = value;
		}
	}

	public String KLTXT {
		get {
			return mKLTXT;
		}
		set {
			mKLTXT = value;
		}
	}

	public String MCDS3 {
		get {
			return mMCDS3;
		}
		set {
			mMCDS3 = value;
		}
	}

	BdiXCCpExtraccionSAP_CentroCosto(){
	}

	BdiXCCpExtraccionSAP_CentroCosto(){ref string KOSTL, string KTEXT, string KLTXT, string MCDS3)
		mKOSTL = KOSTL;
		mKTEXT = KTEXT;
		mKLTXT = KLTXT;
		mMCDS3 = MCDS3;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
