public class clsBeAcfUNMt_Unimed : ICloneable {

	private int mUNMid = 0;
	private string mUNMunidad = '';
	private string mUNMdetalle = '';

	public Integer UNMid {
		get {
			return mUNMid;
		}
		set {
			mUNMid = value;
		}
	}

	public String UNMunidad {
		get {
			return mUNMunidad;
		}
		set {
			mUNMunidad = value;
		}
	}

	public String UNMdetalle {
		get {
			return mUNMdetalle;
		}
		set {
			mUNMdetalle = value;
		}
	}

	AcfUNMt_Unimed(){
	}

	AcfUNMt_Unimed(){ref int UNMid, string UNMunidad, string UNMdetalle)
		mUNMid = UNMid;
		mUNMunidad = UNMunidad;
		mUNMdetalle = UNMdetalle;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
