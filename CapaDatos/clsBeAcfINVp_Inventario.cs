public class clsBeAcfINVp_Inventario : ICloneable {

	private int mINVid = 0;
	private string mINVdetalle = '';
	private Date mINVinicio = Date.Now();
	private Date mINVcierre = Date.Now();
	private bool mINVactivo = False;

	public Integer INVid {
		get {
			return mINVid;
		}
		set {
			mINVid = value;
		}
	}

	public String INVdetalle {
		get {
			return mINVdetalle;
		}
		set {
			mINVdetalle = value;
		}
	}

	public Date INVinicio {
		get {
			return mINVinicio;
		}
		set {
			mINVinicio = value;
		}
	}

	public Date INVcierre {
		get {
			return mINVcierre;
		}
		set {
			mINVcierre = value;
		}
	}

	public Boolean INVactivo {
		get {
			return mINVactivo;
		}
		set {
			mINVactivo = value;
		}
	}

	AcfINVp_Inventario(){
	}

	AcfINVp_Inventario(){ref int INVid, string INVdetalle, Date INVinicio, Date INVcierre, bool INVactivo)
		mINVid = INVid;
		mINVdetalle = INVdetalle;
		mINVinicio = INVinicio;
		mINVcierre = INVcierre;
		mINVactivo = INVactivo;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
