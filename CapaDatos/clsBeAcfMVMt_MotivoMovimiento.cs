public class clsBeAcfMVMt_MotivoMovimiento : ICloneable {

	private string mTMVid = '';
	private string mMVMid = '';
	private string mMVMmotivomovimiento = '';
	private int mMVMjustificacion = 0;

	public String TMVid {
		get {
			return mTMVid;
		}
		set {
			mTMVid = value;
		}
	}

	public String MVMid {
		get {
			return mMVMid;
		}
		set {
			mMVMid = value;
		}
	}

	public String MVMmotivomovimiento {
		get {
			return mMVMmotivomovimiento;
		}
		set {
			mMVMmotivomovimiento = value;
		}
	}

	public Integer MVMjustificacion {
		get {
			return mMVMjustificacion;
		}
		set {
			mMVMjustificacion = value;
		}
	}

	AcfMVMt_MotivoMovimiento(){
	}

	AcfMVMt_MotivoMovimiento(){ref string TMVid, string MVMid, string MVMmotivomovimiento, int MVMjustificacion)
		mTMVid = TMVid;
		mMVMid = MVMid;
		mMVMmotivomovimiento = MVMmotivomovimiento;
		mMVMjustificacion = MVMjustificacion;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
