public class clsBeAcfSELt_SistemaElectrico : ICloneable {

	private string mSELid = '';
	private string mSELsistemaelectrico = '';
	private string mSEGMENT = '';

	public String SELid {
		get {
			return mSELid;
		}
		set {
			mSELid = value;
		}
	}

	public String SELsistemaelectrico {
		get {
			return mSELsistemaelectrico;
		}
		set {
			mSELsistemaelectrico = value;
		}
	}

	public String SEGMENT {
		get {
			return mSEGMENT;
		}
		set {
			mSEGMENT = value;
		}
	}

	AcfSELt_SistemaElectrico(){
	}

	AcfSELt_SistemaElectrico(){ref string SELid, string SELsistemaelectrico, string SEGMENT)
		mSELid = SELid;
		mSELsistemaelectrico = SELsistemaelectrico;
		mSEGMENT = SEGMENT;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
