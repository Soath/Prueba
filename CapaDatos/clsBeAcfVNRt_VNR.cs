public class clsBeAcfVNRt_VNR : ICloneable {

	private string mVNRid = '';
	private string mVNRvnr = '';
	private string mVNRcuenta = '';
	private string mVNRcuentadep = '';

	public String VNRid {
		get {
			return mVNRid;
		}
		set {
			mVNRid = value;
		}
	}

	public String VNRvnr {
		get {
			return mVNRvnr;
		}
		set {
			mVNRvnr = value;
		}
	}

	public String VNRcuenta {
		get {
			return mVNRcuenta;
		}
		set {
			mVNRcuenta = value;
		}
	}

	public String VNRcuentadep {
		get {
			return mVNRcuentadep;
		}
		set {
			mVNRcuentadep = value;
		}
	}

	AcfVNRt_VNR(){
	}

	AcfVNRt_VNR(){ref string VNRid, string VNRvnr, string VNRcuenta, string VNRcuentadep)
		mVNRid = VNRid;
		mVNRvnr = VNRvnr;
		mVNRcuenta = VNRcuenta;
		mVNRcuentadep = VNRcuentadep;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
