public class clsBeBdiCAFpClaseDeActivoFijo : ICloneable {

	private string mANLKL = '';
	private string mTXK50 = '';

	public String ANLKL {
		get {
			return mANLKL;
		}
		set {
			mANLKL = value;
		}
	}

	public String TXK50 {
		get {
			return mTXK50;
		}
		set {
			mTXK50 = value;
		}
	}

	BdiCAFpClaseDeActivoFijo(){
	}

	BdiCAFpClaseDeActivoFijo(){ref string ANLKL, string TXK50)
		mANLKL = ANLKL;
		mTXK50 = TXK50;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
