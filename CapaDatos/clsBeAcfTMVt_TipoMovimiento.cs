public class clsBeAcfTMVt_TipoMovimiento : ICloneable {

	private string mTMVid = '';
	private string mTMVtipomovimiento = '';

	public String TMVid {
		get {
			return mTMVid;
		}
		set {
			mTMVid = value;
		}
	}

	public String TMVtipomovimiento {
		get {
			return mTMVtipomovimiento;
		}
		set {
			mTMVtipomovimiento = value;
		}
	}

	AcfTMVt_TipoMovimiento(){
	}

	AcfTMVt_TipoMovimiento(){ref string TMVid, string TMVtipomovimiento)
		mTMVid = TMVid;
		mTMVtipomovimiento = TMVtipomovimiento;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
