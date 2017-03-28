public class clsBeAcfRVAt_registrovaluacion : ICloneable {

	private string mRVAcodigo = '';
	private string mRVAperiodo = '';
	private string mRVAfecha = '';
	private string mRVAresponsable = '';
	private string mRVRestado = '';

	public String RVAcodigo {
		get {
			return mRVAcodigo;
		}
		set {
			mRVAcodigo = value;
		}
	}

	public String RVAperiodo {
		get {
			return mRVAperiodo;
		}
		set {
			mRVAperiodo = value;
		}
	}

	public String RVAfecha {
		get {
			return mRVAfecha;
		}
		set {
			mRVAfecha = value;
		}
	}

	public String RVAresponsable {
		get {
			return mRVAresponsable;
		}
		set {
			mRVAresponsable = value;
		}
	}

	public String RVRestado {
		get {
			return mRVRestado;
		}
		set {
			mRVRestado = value;
		}
	}

	AcfRVAt_registrovaluacion(){
	}

	AcfRVAt_registrovaluacion(){ref string RVAcodigo, string RVAperiodo, string RVAfecha, string RVAresponsable, string RVRestado)
		mRVAcodigo = RVAcodigo;
		mRVAperiodo = RVAperiodo;
		mRVAfecha = RVAfecha;
		mRVAresponsable = RVAresponsable;
		mRVRestado = RVRestado;
	}

	public object Clone() {
		return base.MemberwiseClone();
	}

}
