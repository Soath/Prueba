public class clsBeAcfACTt_Actividad : ICloneable {

	private string mACTid = '';
	private string mACTactividad = '';

	public String ACTid {
		get {
			return mACTid;
		}
		set {
			mACTid = value;
		}
	}

	public String ACTactividad {
		get {
			return mACTactividad;
		}
		set {
			mACTactividad = value;
		}
	}

	AcfACTt_Actividad(){
	}

	AcfACTt_Actividad(){ref string ACTid, string ACTactividad)
		mACTid = ACTid;
		mACTactividad = ACTactividad;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
