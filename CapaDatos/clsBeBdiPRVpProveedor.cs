public class clsBeBdiPRVpProveedor : ICloneable {

	private string mLIFNR = '';
	private string mName1 = '';
	private string mStras = '';
	private string mSTCD1 = '';

	public String LIFNR {
		get {
			return mLIFNR;
		}
		set {
			mLIFNR = value;
		}
	}

	public String Name1 {
		get {
			return mName1;
		}
		set {
			mName1 = value;
		}
	}

	public String Stras {
		get {
			return mStras;
		}
		set {
			mStras = value;
		}
	}

	public String STCD1 {
		get {
			return mSTCD1;
		}
		set {
			mSTCD1 = value;
		}
	}

	BdiPRVpProveedor(){
	}

	BdiPRVpProveedor(){ref string LIFNR, string Name1, string Stras, string STCD1)
		mLIFNR = LIFNR;
		mName1 = Name1;
		mStras = Stras;
		mSTCD1 = STCD1;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
