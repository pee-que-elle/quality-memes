using System;
using UnityEngine;

// Token: 0x020000C4 RID: 196
public abstract class BLMNBILNMOE : MonoBehaviour
{
	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x060017AB RID: 6059 RVA: 0x0000C762 File Offset: 0x0000A962
	public GameObject LMOECGCMJKK
	{
		get
		{
			if (this.DMNLFJLKGHJ == null)
			{
				this.DMNLFJLKGHJ = base.gameObject;
			}
			return this.DMNLFJLKGHJ;
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x060017AC RID: 6060 RVA: 0x0000C784 File Offset: 0x0000A984
	public Transform CGDFDPHIENG
	{
		get
		{
			if (this.BLLEFKOLKLP == null)
			{
				this.BLLEFKOLKLP = base.transform;
			}
			return this.BLLEFKOLKLP;
		}
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x060017AD RID: 6061 RVA: 0x0000C7A6 File Offset: 0x0000A9A6
	public Camera DGFFHGQEJLH
	{
		get
		{
			if (!this.EOIMBFBMNLH)
			{
				this.PNPFEMQFDJE();
			}
			return this.OJIDBLEKBBO;
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x060017AE RID: 6062 RVA: 0x000A7748 File Offset: 0x000A5948
	public bool IQKPIEHJMDH
	{
		get
		{
			return this.HJDMKGDLJEP.target && this.HKPCCMEEHDL.target && this.NOPCJFECJDP.target && this.LBGJKGDECCN.target;
		}
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x060017AF RID: 6063 RVA: 0x0000C7BC File Offset: 0x0000A9BC
	public virtual bool GHLPPQOBKLN
	{
		get
		{
			return this.HJDMKGDLJEP.target || this.HKPCCMEEHDL.target;
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x060017B0 RID: 6064 RVA: 0x0000C7E3 File Offset: 0x0000A9E3
	public virtual bool MQKHMKGCJLC
	{
		get
		{
			return this.LBGJKGDECCN.target || this.NOPCJFECJDP.target;
		}
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x060017B1 RID: 6065 RVA: 0x0000B03A File Offset: 0x0000923A
	public virtual bool LNBNDKMGEOK
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x060017B2 RID: 6066 RVA: 0x0000C80A File Offset: 0x0000AA0A
	public BLMNBILNMOE KJIHDMEHLIH
	{
		get
		{
			if (!this.PCKBJCKICEL)
			{
				this.PCKBJCKICEL = true;
				this.HMQLMOFCJIO = IKBQNBHOJJB.BBDJCHKMCPI<BLMNBILNMOE>(this.CGDFDPHIENG.parent);
			}
			return this.HMQLMOFCJIO;
		}
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x060017B3 RID: 6067 RVA: 0x000A77A0 File Offset: 0x000A59A0
	public GKDCBJPLQLQ QOBPIJDBNGL
	{
		get
		{
			if (this.KJIHDMEHLIH != null)
			{
				return this.HMQLMOFCJIO.QOBPIJDBNGL;
			}
			if (!this.EFEKBGHICMK)
			{
				this.EFEKBGHICMK = true;
				this.KLLHOMMGBLK = IKBQNBHOJJB.BBDJCHKMCPI<GKDCBJPLQLQ>(this.CGDFDPHIENG);
			}
			return this.KLLHOMMGBLK;
		}
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x060017B4 RID: 6068 RVA: 0x000A77F0 File Offset: 0x000A59F0
	public bool IEEHOJCLFDJ
	{
		get
		{
			return (this.HJDMKGDLJEP.target || this.HKPCCMEEHDL.target || this.NOPCJFECJDP.target || this.LBGJKGDECCN.target) && this.LNBNDKMGEOK;
		}
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x060017B5 RID: 6069
	// (set) Token: 0x060017B6 RID: 6070
	public abstract float DIIHJCJOKMP { get; set; }

	// Token: 0x060017B7 RID: 6071
	public abstract float DBQOIOGLLEF(int DGKHPOCGFHF);

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x060017B8 RID: 6072
	public abstract Vector3[] PIGMLPNGMNO { get; }

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x060017B9 RID: 6073
	public abstract Vector3[] PMCNQICHCLE { get; }

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x060017BA RID: 6074 RVA: 0x000A7850 File Offset: 0x000A5A50
	protected float JLQJGIICODL
	{
		get
		{
			if (this.DGFFHGQEJLH == null)
			{
				return 0f;
			}
			if (!this.OJIDBLEKBBO.orthographic)
			{
				Transform cgdfdphieng = this.CGDFDPHIENG;
				Transform transform = this.OJIDBLEKBBO.transform;
				Plane plane = new Plane(cgdfdphieng.rotation * Vector3.back, cgdfdphieng.position);
				Ray ray = new Ray(transform.position, transform.rotation * Vector3.forward);
				float result;
				if (plane.Raycast(ray, out result))
				{
					return result;
				}
			}
			return Mathf.Lerp(this.OJIDBLEKBBO.nearClipPlane, this.OJIDBLEKBBO.farClipPlane, 0.5f);
		}
	}

	// Token: 0x060017BB RID: 6075 RVA: 0x000A78FC File Offset: 0x000A5AFC
	public virtual void CKLIDQPPPON(bool CKCPEMIBLKH)
	{
		this.LHQDFLPFGME = true;
		if (CKCPEMIBLKH)
		{
			for (int i = 0; i < this.HKDQQHLCNPP.BJGMIBBEGDQ; i++)
			{
				this.HKDQQHLCNPP.KLCIGFMQNFH[i].CKLIDQPPPON(true);
			}
		}
	}

	// Token: 0x060017BC RID: 6076 RVA: 0x000A793C File Offset: 0x000A5B3C
	public virtual Vector3[] MKFNGPBMOKP(Transform ENOQKGBPJKQ)
	{
		if (this.DGFFHGQEJLH != null)
		{
			return this.OJIDBLEKBBO.MKFNGPBMOKP(this.JLQJGIICODL, ENOQKGBPJKQ);
		}
		Vector3 position = this.CGDFDPHIENG.position;
		for (int i = 0; i < 4; i++)
		{
			BLMNBILNMOE.BGCNPFKJPFD[i] = position;
		}
		if (ENOQKGBPJKQ != null)
		{
			for (int j = 0; j < 4; j++)
			{
				BLMNBILNMOE.BGCNPFKJPFD[j] = ENOQKGBPJKQ.InverseTransformPoint(BLMNBILNMOE.BGCNPFKJPFD[j]);
			}
		}
		return BLMNBILNMOE.BGCNPFKJPFD;
	}

	// Token: 0x060017BD RID: 6077 RVA: 0x000A79D4 File Offset: 0x000A5BD4
	protected Vector3 IFGLHHBDJCJ(BLMNBILNMOE.AnchorPoint PLQBLMMGMHM, Transform HHMCPQQKIKB)
	{
		if (!(this.DGFFHGQEJLH == null) && !(PLQBLMMGMHM.targetCam == null))
		{
			Rect rect = PLQBLMMGMHM.targetCam.rect;
			Vector3 vector = PLQBLMMGMHM.targetCam.WorldToViewportPoint(PLQBLMMGMHM.target.position);
			Vector3 vector2 = new Vector3(vector.x * rect.width + rect.x, vector.y * rect.height + rect.y, vector.z);
			vector2 = this.OJIDBLEKBBO.ViewportToWorldPoint(vector2);
			if (HHMCPQQKIKB != null)
			{
				vector2 = HHMCPQQKIKB.InverseTransformPoint(vector2);
			}
			vector2.x = Mathf.Floor(vector2.x + 0.5f);
			vector2.y = Mathf.Floor(vector2.y + 0.5f);
			return vector2;
		}
		return this.CGDFDPHIENG.localPosition;
	}

	// Token: 0x060017BE RID: 6078 RVA: 0x0000C837 File Offset: 0x0000AA37
	protected virtual void OnEnable()
	{
		this.EHGKGFDCEEK = -1;
		if (this.NMOPFIDPGDB == BLMNBILNMOE.PCOFBQMMOOO.OnEnable)
		{
			this.EOIMBFBMNLH = false;
			this.LMLGDHPKJCE = true;
		}
		if (this.PNBOOLEOKCI)
		{
			this.FHJOQKCCMDH();
		}
		this.EHGKGFDCEEK = -1;
	}

	// Token: 0x060017BF RID: 6079 RVA: 0x0000C86B File Offset: 0x0000AA6B
	protected virtual void FHJOQKCCMDH()
	{
		this.LHQDFLPFGME = true;
		this.EFEKBGHICMK = false;
		this.PCKBJCKICEL = false;
		if (this.KJIHDMEHLIH != null)
		{
			this.HMQLMOFCJIO.HKDQQHLCNPP.LHQECHHMOGD(this);
		}
	}

	// Token: 0x060017C0 RID: 6080 RVA: 0x0000C8A1 File Offset: 0x0000AAA1
	protected virtual void OnDisable()
	{
		if (this.HMQLMOFCJIO)
		{
			this.HMQLMOFCJIO.HKDQQHLCNPP.FQDMDDOHCQJ(this);
		}
		this.HMQLMOFCJIO = null;
		this.KLLHOMMGBLK = null;
		this.EFEKBGHICMK = false;
		this.PCKBJCKICEL = false;
	}

	// Token: 0x060017C1 RID: 6081 RVA: 0x0000C8DE File Offset: 0x0000AADE
	protected virtual void Awake()
	{
		this.PNBOOLEOKCI = false;
		this.DMNLFJLKGHJ = base.gameObject;
		this.BLLEFKOLKLP = base.transform;
	}

	// Token: 0x060017C2 RID: 6082 RVA: 0x0000C8FF File Offset: 0x0000AAFF
	protected void Start()
	{
		this.PNBOOLEOKCI = true;
		this.FHJOQKCCMDH();
		this.NHONJJHBBEN();
	}

	// Token: 0x060017C3 RID: 6083 RVA: 0x000A7AC0 File Offset: 0x000A5CC0
	public void Update()
	{
		if (!this.EOIMBFBMNLH)
		{
			this.PNPFEMQFDJE();
		}
		int frameCount = Time.frameCount;
		if (this.EHGKGFDCEEK != frameCount)
		{
			if (this.NMOPFIDPGDB == BLMNBILNMOE.PCOFBQMMOOO.OnUpdate || this.LMLGDHPKJCE)
			{
				this.HFDFOPHEJHB(frameCount);
			}
			this.BOIOGNMBEGD();
		}
	}

	// Token: 0x060017C4 RID: 6084 RVA: 0x000A7B08 File Offset: 0x000A5D08
	protected void HFDFOPHEJHB(int DQLNIPIGLHK)
	{
		this.EHGKGFDCEEK = DQLNIPIGLHK;
		this.LMLGDHPKJCE = false;
		bool flag = false;
		if (this.HJDMKGDLJEP.target)
		{
			flag = true;
			if (this.HJDMKGDLJEP.rect != null && this.HJDMKGDLJEP.rect.EHGKGFDCEEK != DQLNIPIGLHK)
			{
				this.HJDMKGDLJEP.rect.Update();
			}
		}
		if (this.LBGJKGDECCN.target)
		{
			flag = true;
			if (this.LBGJKGDECCN.rect != null && this.LBGJKGDECCN.rect.EHGKGFDCEEK != DQLNIPIGLHK)
			{
				this.LBGJKGDECCN.rect.Update();
			}
		}
		if (this.HKPCCMEEHDL.target)
		{
			flag = true;
			if (this.HKPCCMEEHDL.rect != null && this.HKPCCMEEHDL.rect.EHGKGFDCEEK != DQLNIPIGLHK)
			{
				this.HKPCCMEEHDL.rect.Update();
			}
		}
		if (this.NOPCJFECJDP.target)
		{
			flag = true;
			if (this.NOPCJFECJDP.rect != null && this.NOPCJFECJDP.rect.EHGKGFDCEEK != DQLNIPIGLHK)
			{
				this.NOPCJFECJDP.rect.Update();
			}
		}
		if (flag)
		{
			this.NEBPQFKGHLL();
		}
	}

	// Token: 0x060017C5 RID: 6085 RVA: 0x0000C914 File Offset: 0x0000AB14
	public void UpdateAnchors()
	{
		if (this.IEEHOJCLFDJ)
		{
			this.EHGKGFDCEEK = -1;
			this.LMLGDHPKJCE = true;
			this.HFDFOPHEJHB(Time.frameCount);
		}
	}

	// Token: 0x060017C6 RID: 6086
	protected abstract void NEBPQFKGHLL();

	// Token: 0x060017C7 RID: 6087 RVA: 0x0000C937 File Offset: 0x0000AB37
	public void KPBQIFMCLFH(Transform OQJFBJQJEFG)
	{
		this.HJDMKGDLJEP.target = OQJFBJQJEFG;
		this.HKPCCMEEHDL.target = OQJFBJQJEFG;
		this.NOPCJFECJDP.target = OQJFBJQJEFG;
		this.LBGJKGDECCN.target = OQJFBJQJEFG;
		this.PNPFEMQFDJE();
		this.UpdateAnchors();
	}

	// Token: 0x060017C8 RID: 6088 RVA: 0x000A7C58 File Offset: 0x000A5E58
	public void KPBQIFMCLFH(GameObject CGHIENBIHCO)
	{
		Transform target = (!(CGHIENBIHCO != null)) ? null : CGHIENBIHCO.transform;
		this.HJDMKGDLJEP.target = target;
		this.HKPCCMEEHDL.target = target;
		this.NOPCJFECJDP.target = target;
		this.LBGJKGDECCN.target = target;
		this.PNPFEMQFDJE();
		this.UpdateAnchors();
	}

	// Token: 0x060017C9 RID: 6089 RVA: 0x000A7CB4 File Offset: 0x000A5EB4
	public void KPBQIFMCLFH(GameObject CGHIENBIHCO, int DEQIFCDFMDK, int FPIPDOBGBQH, int JKDFCPKCQJP, int FNKCEOPHHKL)
	{
		Transform target = (!(CGHIENBIHCO != null)) ? null : CGHIENBIHCO.transform;
		this.HJDMKGDLJEP.target = target;
		this.HKPCCMEEHDL.target = target;
		this.NOPCJFECJDP.target = target;
		this.LBGJKGDECCN.target = target;
		this.HJDMKGDLJEP.relative = 0f;
		this.HKPCCMEEHDL.relative = 1f;
		this.LBGJKGDECCN.relative = 0f;
		this.NOPCJFECJDP.relative = 1f;
		this.HJDMKGDLJEP.absolute = DEQIFCDFMDK;
		this.HKPCCMEEHDL.absolute = JKDFCPKCQJP;
		this.LBGJKGDECCN.absolute = FPIPDOBGBQH;
		this.NOPCJFECJDP.absolute = FNKCEOPHHKL;
		this.PNPFEMQFDJE();
		this.UpdateAnchors();
	}

	// Token: 0x060017CA RID: 6090 RVA: 0x000A7D84 File Offset: 0x000A5F84
	public void KPBQIFMCLFH(GameObject CGHIENBIHCO, float DEQIFCDFMDK, float FPIPDOBGBQH, float JKDFCPKCQJP, float FNKCEOPHHKL)
	{
		Transform target = (!(CGHIENBIHCO != null)) ? null : CGHIENBIHCO.transform;
		this.HJDMKGDLJEP.target = target;
		this.HKPCCMEEHDL.target = target;
		this.NOPCJFECJDP.target = target;
		this.LBGJKGDECCN.target = target;
		this.HJDMKGDLJEP.relative = DEQIFCDFMDK;
		this.HKPCCMEEHDL.relative = JKDFCPKCQJP;
		this.LBGJKGDECCN.relative = FPIPDOBGBQH;
		this.NOPCJFECJDP.relative = FNKCEOPHHKL;
		this.HJDMKGDLJEP.absolute = 0;
		this.HKPCCMEEHDL.absolute = 0;
		this.LBGJKGDECCN.absolute = 0;
		this.NOPCJFECJDP.absolute = 0;
		this.PNPFEMQFDJE();
		this.UpdateAnchors();
	}

	// Token: 0x060017CB RID: 6091 RVA: 0x000A7E44 File Offset: 0x000A6044
	public void KPBQIFMCLFH(GameObject CGHIENBIHCO, float DEQIFCDFMDK, int KGNFKNNGLQM, float FPIPDOBGBQH, int IHOCEKHGLLB, float JKDFCPKCQJP, int FHBECEMPNQP, float FNKCEOPHHKL, int FFOIIKDOECF)
	{
		Transform target = (!(CGHIENBIHCO != null)) ? null : CGHIENBIHCO.transform;
		this.HJDMKGDLJEP.target = target;
		this.HKPCCMEEHDL.target = target;
		this.NOPCJFECJDP.target = target;
		this.LBGJKGDECCN.target = target;
		this.HJDMKGDLJEP.relative = DEQIFCDFMDK;
		this.HKPCCMEEHDL.relative = JKDFCPKCQJP;
		this.LBGJKGDECCN.relative = FPIPDOBGBQH;
		this.NOPCJFECJDP.relative = FNKCEOPHHKL;
		this.HJDMKGDLJEP.absolute = KGNFKNNGLQM;
		this.HKPCCMEEHDL.absolute = FHBECEMPNQP;
		this.LBGJKGDECCN.absolute = IHOCEKHGLLB;
		this.NOPCJFECJDP.absolute = FFOIIKDOECF;
		this.PNPFEMQFDJE();
		this.UpdateAnchors();
	}

	// Token: 0x060017CC RID: 6092 RVA: 0x000A7F08 File Offset: 0x000A6108
	public void KPBQIFMCLFH(float DEQIFCDFMDK, int KGNFKNNGLQM, float FPIPDOBGBQH, int IHOCEKHGLLB, float JKDFCPKCQJP, int FHBECEMPNQP, float FNKCEOPHHKL, int FFOIIKDOECF)
	{
		Transform parent = this.CGDFDPHIENG.parent;
		this.HJDMKGDLJEP.target = parent;
		this.HKPCCMEEHDL.target = parent;
		this.NOPCJFECJDP.target = parent;
		this.LBGJKGDECCN.target = parent;
		this.HJDMKGDLJEP.relative = DEQIFCDFMDK;
		this.HKPCCMEEHDL.relative = JKDFCPKCQJP;
		this.LBGJKGDECCN.relative = FPIPDOBGBQH;
		this.NOPCJFECJDP.relative = FNKCEOPHHKL;
		this.HJDMKGDLJEP.absolute = KGNFKNNGLQM;
		this.HKPCCMEEHDL.absolute = FHBECEMPNQP;
		this.LBGJKGDECCN.absolute = IHOCEKHGLLB;
		this.NOPCJFECJDP.absolute = FFOIIKDOECF;
		this.PNPFEMQFDJE();
		this.UpdateAnchors();
	}

	// Token: 0x060017CD RID: 6093 RVA: 0x000A7FC4 File Offset: 0x000A61C4
	public void PEGLFHKHDOF(int DEQIFCDFMDK, int FNKCEOPHHKL, int KJGMGPCEJJD, int DFKQMMIQDOO)
	{
		this.KPBQIFMCLFH(0f, DEQIFCDFMDK, 1f, -FNKCEOPHHKL - DFKQMMIQDOO, 0f, DEQIFCDFMDK + KJGMGPCEJJD, 1f, -FNKCEOPHHKL);
	}

	// Token: 0x060017CE RID: 6094 RVA: 0x000A7FF8 File Offset: 0x000A61F8
	public void PNPFEMQFDJE()
	{
		this.EOIMBFBMNLH = true;
		this.HJDMKGDLJEP.rect = ((!this.HJDMKGDLJEP.target) ? null : this.HJDMKGDLJEP.target.GetComponent<BLMNBILNMOE>());
		this.LBGJKGDECCN.rect = ((!this.LBGJKGDECCN.target) ? null : this.LBGJKGDECCN.target.GetComponent<BLMNBILNMOE>());
		this.HKPCCMEEHDL.rect = ((!this.HKPCCMEEHDL.target) ? null : this.HKPCCMEEHDL.target.GetComponent<BLMNBILNMOE>());
		this.NOPCJFECJDP.rect = ((!this.NOPCJFECJDP.target) ? null : this.NOPCJFECJDP.target.GetComponent<BLMNBILNMOE>());
		this.OJIDBLEKBBO = IKBQNBHOJJB.FINJNKFMLMO(this.LMOECGCMJKK.layer);
		this.QFQJOMDQNPJ(this.HJDMKGDLJEP);
		this.QFQJOMDQNPJ(this.LBGJKGDECCN);
		this.QFQJOMDQNPJ(this.HKPCCMEEHDL);
		this.QFQJOMDQNPJ(this.NOPCJFECJDP);
		this.LMLGDHPKJCE = true;
	}

	// Token: 0x060017CF RID: 6095 RVA: 0x0000C975 File Offset: 0x0000AB75
	public void PMGPMBIBOJB()
	{
		this.PNPFEMQFDJE();
		this.UpdateAnchors();
	}

	// Token: 0x060017D0 RID: 6096
	public abstract void LOIPCGLJGPI(float DGKOIGOLHDM, float DDLQKFDFMCJ, float KJGMGPCEJJD, float DFKQMMIQDOO);

	// Token: 0x060017D1 RID: 6097 RVA: 0x000A811C File Offset: 0x000A631C
	private void QFQJOMDQNPJ(BLMNBILNMOE.AnchorPoint QHBFEPKEKHG)
	{
		if (!(QHBFEPKEKHG.target == null) && !(QHBFEPKEKHG.rect != null))
		{
			QHBFEPKEKHG.targetCam = IKBQNBHOJJB.FINJNKFMLMO(QHBFEPKEKHG.target.gameObject.layer);
		}
		else
		{
			QHBFEPKEKHG.targetCam = null;
		}
	}

	// Token: 0x060017D2 RID: 6098 RVA: 0x000A816C File Offset: 0x000A636C
	public virtual void HGBNNJQOKLO()
	{
		this.PCKBJCKICEL = false;
		BLMNBILNMOE blmnbilnmoe = IKBQNBHOJJB.BBDJCHKMCPI<BLMNBILNMOE>(this.CGDFDPHIENG.parent);
		if (this.HMQLMOFCJIO != blmnbilnmoe)
		{
			if (this.HMQLMOFCJIO)
			{
				this.HMQLMOFCJIO.HKDQQHLCNPP.FQDMDDOHCQJ(this);
			}
			this.HMQLMOFCJIO = blmnbilnmoe;
			if (this.HMQLMOFCJIO)
			{
				this.HMQLMOFCJIO.HKDQQHLCNPP.LHQECHHMOGD(this);
			}
			this.EFEKBGHICMK = false;
		}
	}

	// Token: 0x060017D3 RID: 6099
	protected abstract void NHONJJHBBEN();

	// Token: 0x060017D4 RID: 6100 RVA: 0x00002300 File Offset: 0x00000500
	protected virtual void BOIOGNMBEGD()
	{
	}

	// Token: 0x040004A9 RID: 1193
	public BLMNBILNMOE.AnchorPoint HJDMKGDLJEP = new BLMNBILNMOE.AnchorPoint();

	// Token: 0x040004AA RID: 1194
	public BLMNBILNMOE.AnchorPoint HKPCCMEEHDL = new BLMNBILNMOE.AnchorPoint(1f);

	// Token: 0x040004AB RID: 1195
	public BLMNBILNMOE.AnchorPoint LBGJKGDECCN = new BLMNBILNMOE.AnchorPoint();

	// Token: 0x040004AC RID: 1196
	public BLMNBILNMOE.AnchorPoint NOPCJFECJDP = new BLMNBILNMOE.AnchorPoint(1f);

	// Token: 0x040004AD RID: 1197
	public BLMNBILNMOE.PCOFBQMMOOO NMOPFIDPGDB = BLMNBILNMOE.PCOFBQMMOOO.OnUpdate;

	// Token: 0x040004AE RID: 1198
	[NonSerialized]
	protected GameObject DMNLFJLKGHJ;

	// Token: 0x040004AF RID: 1199
	[NonSerialized]
	protected Transform BLLEFKOLKLP;

	// Token: 0x040004B0 RID: 1200
	[NonSerialized]
	protected MHIDKMCBQEN<BLMNBILNMOE> HKDQQHLCNPP = new MHIDKMCBQEN<BLMNBILNMOE>();

	// Token: 0x040004B1 RID: 1201
	[NonSerialized]
	protected bool LHQDFLPFGME = true;

	// Token: 0x040004B2 RID: 1202
	[NonSerialized]
	protected bool PCKBJCKICEL;

	// Token: 0x040004B3 RID: 1203
	[NonSerialized]
	private bool LMLGDHPKJCE = true;

	// Token: 0x040004B4 RID: 1204
	[NonSerialized]
	private int EHGKGFDCEEK = -1;

	// Token: 0x040004B5 RID: 1205
	[NonSerialized]
	private bool EOIMBFBMNLH;

	// Token: 0x040004B6 RID: 1206
	[NonSerialized]
	private GKDCBJPLQLQ KLLHOMMGBLK;

	// Token: 0x040004B7 RID: 1207
	[NonSerialized]
	private BLMNBILNMOE HMQLMOFCJIO;

	// Token: 0x040004B8 RID: 1208
	[NonSerialized]
	private bool EFEKBGHICMK;

	// Token: 0x040004B9 RID: 1209
	[NonSerialized]
	protected Camera OJIDBLEKBBO;

	// Token: 0x040004BA RID: 1210
	protected bool PNBOOLEOKCI;

	// Token: 0x040004BB RID: 1211
	[NonSerialized]
	public float NHCNEDEEONK = 1f;

	// Token: 0x040004BC RID: 1212
	protected static Vector3[] BGCNPFKJPFD = new Vector3[4];

	// Token: 0x020000C5 RID: 197
	[Serializable]
	public class AnchorPoint
	{
		// Token: 0x060017D6 RID: 6102 RVA: 0x000A81EC File Offset: 0x000A63EC
		public Vector3[] KOILGBJDMNJ(Transform ENOQKGBPJKQ)
		{
			if (this.target != null)
			{
				if (this.rect != null)
				{
					return this.rect.MKFNGPBMOKP(ENOQKGBPJKQ);
				}
				Camera component = this.target.GetComponent<Camera>();
				if (component != null)
				{
					return component.MKFNGPBMOKP(ENOQKGBPJKQ);
				}
			}
			return null;
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x000A8240 File Offset: 0x000A6440
		public void JPCQOJEKMLO(Transform KJIHDMEHLIH, float PNNOLPKBHNQ)
		{
			if (this.rect)
			{
				Vector3[] array = this.rect.MKFNGPBMOKP(KJIHDMEHLIH);
				float num = Mathf.Lerp(array[0].y, array[0].y, this.relative);
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - num + 7f);
			}
			else
			{
				Vector3 position = this.target.position;
				if (KJIHDMEHLIH != null)
				{
					position = KJIHDMEHLIH.InverseTransformPoint(position);
				}
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - position.y + 1618f);
			}
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x00002375 File Offset: 0x00000575
		public AnchorPoint()
		{
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x000A81EC File Offset: 0x000A63EC
		public Vector3[] IGOHKMJFION(Transform ENOQKGBPJKQ)
		{
			if (this.target != null)
			{
				if (this.rect != null)
				{
					return this.rect.MKFNGPBMOKP(ENOQKGBPJKQ);
				}
				Camera component = this.target.GetComponent<Camera>();
				if (component != null)
				{
					return component.MKFNGPBMOKP(ENOQKGBPJKQ);
				}
			}
			return null;
		}

		// Token: 0x060017DA RID: 6106 RVA: 0x0000C990 File Offset: 0x0000AB90
		public void IEJMMIJMKFG(float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			this.HCQJIHONLLG(62f, 1616f, 1805f, EMGIPNLQGJK, PIQMBELPJQQ, OQFDCGMDLKC);
		}

		// Token: 0x060017DB RID: 6107 RVA: 0x0000C9AA File Offset: 0x0000ABAA
		public void KODHLLDFKGO(float FKHPMFLQFJP, float LIKNFCJLBGM)
		{
			this.relative = FKHPMFLQFJP;
			this.absolute = Mathf.FloorToInt(LIKNFCJLBGM + 261f);
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x0000C9C5 File Offset: 0x0000ABC5
		public void PJMIKDIEGMB(float FKHPMFLQFJP, float LIKNFCJLBGM)
		{
			this.relative = FKHPMFLQFJP;
			this.absolute = Mathf.FloorToInt(LIKNFCJLBGM + 0.5f);
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x000A82D8 File Offset: 0x000A64D8
		public void DELHPQMIBQJ(float EGHLNPDHCLL, float EBIHBDMJJLI, float MIBFDQNFMIF, float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			float num = Mathf.Abs(EMGIPNLQGJK);
			float num2 = Mathf.Abs(PIQMBELPJQQ);
			float num3 = Mathf.Abs(OQFDCGMDLKC);
			if (num < num2 && num < num3)
			{
				this.KODHLLDFKGO(EGHLNPDHCLL, EMGIPNLQGJK);
			}
			else if (num2 < num && num2 < num3)
			{
				this.KODHLLDFKGO(EBIHBDMJJLI, PIQMBELPJQQ);
			}
			else
			{
				this.KDBPHMJLPLI(MIBFDQNFMIF, OQFDCGMDLKC);
			}
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x0000C9E0 File Offset: 0x0000ABE0
		public void OKLCPPKLLKQ(float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			this.HCQJIHONLLG(1816f, 1670f, 1740f, EMGIPNLQGJK, PIQMBELPJQQ, OQFDCGMDLKC);
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x000A832C File Offset: 0x000A652C
		public void QLDIPJFBNGC(Transform KJIHDMEHLIH, float PNNOLPKBHNQ)
		{
			if (this.rect)
			{
				Vector3[] array = this.rect.MKFNGPBMOKP(KJIHDMEHLIH);
				float num = Mathf.Lerp(array[3].y, array[1].y, this.relative);
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - num + 0.5f);
			}
			else
			{
				Vector3 position = this.target.position;
				if (KJIHDMEHLIH != null)
				{
					position = KJIHDMEHLIH.InverseTransformPoint(position);
				}
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - position.y + 0.5f);
			}
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x000A81EC File Offset: 0x000A63EC
		public Vector3[] GIBGLHKJGLO(Transform ENOQKGBPJKQ)
		{
			if (this.target != null)
			{
				if (this.rect != null)
				{
					return this.rect.MKFNGPBMOKP(ENOQKGBPJKQ);
				}
				Camera component = this.target.GetComponent<Camera>();
				if (component != null)
				{
					return component.MKFNGPBMOKP(ENOQKGBPJKQ);
				}
			}
			return null;
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x0000C9FA File Offset: 0x0000ABFA
		public void KDJODMLBQEB(float FKHPMFLQFJP, float LIKNFCJLBGM)
		{
			this.relative = FKHPMFLQFJP;
			this.absolute = Mathf.FloorToInt(LIKNFCJLBGM + 371f);
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x000A83C4 File Offset: 0x000A65C4
		public void FNDNPQCLIGG(Transform KJIHDMEHLIH, float PNNOLPKBHNQ)
		{
			if (this.rect)
			{
				Vector3[] array = this.rect.MKFNGPBMOKP(KJIHDMEHLIH);
				float num = Mathf.Lerp(array[1].x, array[4].x, this.relative);
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - num + 1973f);
			}
			else
			{
				Vector3 position = this.target.position;
				if (KJIHDMEHLIH != null)
				{
					position = KJIHDMEHLIH.InverseTransformPoint(position);
				}
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - position.x + 1016f);
			}
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x0000CA15 File Offset: 0x0000AC15
		public AnchorPoint(float FKHPMFLQFJP)
		{
			this.relative = FKHPMFLQFJP;
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x000A845C File Offset: 0x000A665C
		public void HCQJIHONLLG(float EGHLNPDHCLL, float EBIHBDMJJLI, float MIBFDQNFMIF, float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			float num = Mathf.Abs(EMGIPNLQGJK);
			float num2 = Mathf.Abs(PIQMBELPJQQ);
			float num3 = Mathf.Abs(OQFDCGMDLKC);
			if (num < num2 && num < num3)
			{
				this.PJMIKDIEGMB(EGHLNPDHCLL, EMGIPNLQGJK);
			}
			else if (num2 < num && num2 < num3)
			{
				this.PJMIKDIEGMB(EBIHBDMJJLI, PIQMBELPJQQ);
			}
			else
			{
				this.PJMIKDIEGMB(MIBFDQNFMIF, OQFDCGMDLKC);
			}
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x000A845C File Offset: 0x000A665C
		public void IQNFOEEFJKI(float EGHLNPDHCLL, float EBIHBDMJJLI, float MIBFDQNFMIF, float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			float num = Mathf.Abs(EMGIPNLQGJK);
			float num2 = Mathf.Abs(PIQMBELPJQQ);
			float num3 = Mathf.Abs(OQFDCGMDLKC);
			if (num < num2 && num < num3)
			{
				this.PJMIKDIEGMB(EGHLNPDHCLL, EMGIPNLQGJK);
			}
			else if (num2 < num && num2 < num3)
			{
				this.PJMIKDIEGMB(EBIHBDMJJLI, PIQMBELPJQQ);
			}
			else
			{
				this.PJMIKDIEGMB(MIBFDQNFMIF, OQFDCGMDLKC);
			}
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x000A81EC File Offset: 0x000A63EC
		public Vector3[] FDBKGODBLBN(Transform ENOQKGBPJKQ)
		{
			if (this.target != null)
			{
				if (this.rect != null)
				{
					return this.rect.MKFNGPBMOKP(ENOQKGBPJKQ);
				}
				Camera component = this.target.GetComponent<Camera>();
				if (component != null)
				{
					return component.MKFNGPBMOKP(ENOQKGBPJKQ);
				}
			}
			return null;
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x0000CA24 File Offset: 0x0000AC24
		public void IQNFOEEFJKI(float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			this.IQNFOEEFJKI(0f, 0.5f, 1f, EMGIPNLQGJK, PIQMBELPJQQ, OQFDCGMDLKC);
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x000A84B0 File Offset: 0x000A66B0
		public void IQKKQLICQDG(Transform KJIHDMEHLIH, float PNNOLPKBHNQ)
		{
			if (this.rect)
			{
				Vector3[] array = this.rect.MKFNGPBMOKP(KJIHDMEHLIH);
				float num = Mathf.Lerp(array[8].y, array[1].y, this.relative);
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - num + 1244f);
			}
			else
			{
				Vector3 position = this.target.position;
				if (KJIHDMEHLIH != null)
				{
					position = KJIHDMEHLIH.InverseTransformPoint(position);
				}
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - position.y + 434f);
			}
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x0000CA3E File Offset: 0x0000AC3E
		public void MLEHNJBCBGD(float FKHPMFLQFJP, float LIKNFCJLBGM)
		{
			this.relative = FKHPMFLQFJP;
			this.absolute = Mathf.FloorToInt(LIKNFCJLBGM + 588f);
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x000A81EC File Offset: 0x000A63EC
		public Vector3[] MKFNGPBMOKP(Transform ENOQKGBPJKQ)
		{
			if (this.target != null)
			{
				if (this.rect != null)
				{
					return this.rect.MKFNGPBMOKP(ENOQKGBPJKQ);
				}
				Camera component = this.target.GetComponent<Camera>();
				if (component != null)
				{
					return component.MKFNGPBMOKP(ENOQKGBPJKQ);
				}
			}
			return null;
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x000A81EC File Offset: 0x000A63EC
		public Vector3[] HPJKCFCKGEO(Transform ENOQKGBPJKQ)
		{
			if (this.target != null)
			{
				if (this.rect != null)
				{
					return this.rect.MKFNGPBMOKP(ENOQKGBPJKQ);
				}
				Camera component = this.target.GetComponent<Camera>();
				if (component != null)
				{
					return component.MKFNGPBMOKP(ENOQKGBPJKQ);
				}
			}
			return null;
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x0000CA59 File Offset: 0x0000AC59
		public void KBJDJGKBDQQ(float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			this.BDLOPHJOLOB(107f, 1947f, 314f, EMGIPNLQGJK, PIQMBELPJQQ, OQFDCGMDLKC);
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x000A8548 File Offset: 0x000A6748
		public void FEEHLJLLFJB(Transform KJIHDMEHLIH, float PNNOLPKBHNQ)
		{
			if (this.rect)
			{
				Vector3[] array = this.rect.MKFNGPBMOKP(KJIHDMEHLIH);
				float num = Mathf.Lerp(array[7].y, array[1].y, this.relative);
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - num + 1961f);
			}
			else
			{
				Vector3 position = this.target.position;
				if (KJIHDMEHLIH != null)
				{
					position = KJIHDMEHLIH.InverseTransformPoint(position);
				}
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - position.y + 1626f);
			}
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x0000CA73 File Offset: 0x0000AC73
		public void CEQNIBMEKQN(Transform ILBCCCBJNCL, float FKHPMFLQFJP, float LIKNFCJLBGM)
		{
			this.target = ILBCCCBJNCL;
			this.relative = FKHPMFLQFJP;
			this.absolute = Mathf.FloorToInt(LIKNFCJLBGM + 777f);
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x000A85E0 File Offset: 0x000A67E0
		public void JHOBHJMCDIO(Transform KJIHDMEHLIH, float PNNOLPKBHNQ)
		{
			if (this.rect)
			{
				Vector3[] array = this.rect.MKFNGPBMOKP(KJIHDMEHLIH);
				float num = Mathf.Lerp(array[0].x, array[2].x, this.relative);
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - num + 0.5f);
			}
			else
			{
				Vector3 position = this.target.position;
				if (KJIHDMEHLIH != null)
				{
					position = KJIHDMEHLIH.InverseTransformPoint(position);
				}
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - position.x + 0.5f);
			}
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x000A8678 File Offset: 0x000A6878
		public void CECJKCEDBQO(float EGHLNPDHCLL, float EBIHBDMJJLI, float MIBFDQNFMIF, float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			float num = Mathf.Abs(EMGIPNLQGJK);
			float num2 = Mathf.Abs(PIQMBELPJQQ);
			float num3 = Mathf.Abs(OQFDCGMDLKC);
			if (num < num2 && num < num3)
			{
				this.KODHLLDFKGO(EGHLNPDHCLL, EMGIPNLQGJK);
			}
			else if (num2 < num && num2 < num3)
			{
				this.KDBPHMJLPLI(EBIHBDMJJLI, PIQMBELPJQQ);
			}
			else
			{
				this.PJMIKDIEGMB(MIBFDQNFMIF, OQFDCGMDLKC);
			}
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x0000CA95 File Offset: 0x0000AC95
		public void QFKKHKMEHBD(float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			this.IQNFOEEFJKI(571f, 1235f, 1920f, EMGIPNLQGJK, PIQMBELPJQQ, OQFDCGMDLKC);
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x000A86CC File Offset: 0x000A68CC
		public void OPJOOCQEOFD(Transform KJIHDMEHLIH, float PNNOLPKBHNQ)
		{
			if (this.rect)
			{
				Vector3[] array = this.rect.MKFNGPBMOKP(KJIHDMEHLIH);
				float num = Mathf.Lerp(array[0].x, array[7].x, this.relative);
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - num + 1753f);
			}
			else
			{
				Vector3 position = this.target.position;
				if (KJIHDMEHLIH != null)
				{
					position = KJIHDMEHLIH.InverseTransformPoint(position);
				}
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - position.x + 803f);
			}
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x000A8764 File Offset: 0x000A6964
		public void KGOGLNPMBCQ(Transform KJIHDMEHLIH, float PNNOLPKBHNQ)
		{
			if (this.rect)
			{
				Vector3[] array = this.rect.MKFNGPBMOKP(KJIHDMEHLIH);
				float num = Mathf.Lerp(array[4].y, array[1].y, this.relative);
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - num + 30f);
			}
			else
			{
				Vector3 position = this.target.position;
				if (KJIHDMEHLIH != null)
				{
					position = KJIHDMEHLIH.InverseTransformPoint(position);
				}
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - position.y + 836f);
			}
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x0000CAAF File Offset: 0x0000ACAF
		public void PJMIKDIEGMB(Transform ILBCCCBJNCL, float FKHPMFLQFJP, float LIKNFCJLBGM)
		{
			this.target = ILBCCCBJNCL;
			this.relative = FKHPMFLQFJP;
			this.absolute = Mathf.FloorToInt(LIKNFCJLBGM + 0.5f);
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x000A87FC File Offset: 0x000A69FC
		public void LPIGLDJFGLC(Transform KJIHDMEHLIH, float PNNOLPKBHNQ)
		{
			if (this.rect)
			{
				Vector3[] array = this.rect.MKFNGPBMOKP(KJIHDMEHLIH);
				float num = Mathf.Lerp(array[2].y, array[0].y, this.relative);
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - num + 1131f);
			}
			else
			{
				Vector3 position = this.target.position;
				if (KJIHDMEHLIH != null)
				{
					position = KJIHDMEHLIH.InverseTransformPoint(position);
				}
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - position.y + 216f);
			}
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x000A81EC File Offset: 0x000A63EC
		public Vector3[] KDICDLGMHBG(Transform ENOQKGBPJKQ)
		{
			if (this.target != null)
			{
				if (this.rect != null)
				{
					return this.rect.MKFNGPBMOKP(ENOQKGBPJKQ);
				}
				Camera component = this.target.GetComponent<Camera>();
				if (component != null)
				{
					return component.MKFNGPBMOKP(ENOQKGBPJKQ);
				}
			}
			return null;
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x0000CAD1 File Offset: 0x0000ACD1
		public void KDBPHMJLPLI(float FKHPMFLQFJP, float LIKNFCJLBGM)
		{
			this.relative = FKHPMFLQFJP;
			this.absolute = Mathf.FloorToInt(LIKNFCJLBGM + 1973f);
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x000A8894 File Offset: 0x000A6A94
		public void FJGCELJLJIK(Transform KJIHDMEHLIH, float PNNOLPKBHNQ)
		{
			if (this.rect)
			{
				Vector3[] array = this.rect.MKFNGPBMOKP(KJIHDMEHLIH);
				float num = Mathf.Lerp(array[0].x, array[6].x, this.relative);
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - num + 371f);
			}
			else
			{
				Vector3 position = this.target.position;
				if (KJIHDMEHLIH != null)
				{
					position = KJIHDMEHLIH.InverseTransformPoint(position);
				}
				this.absolute = Mathf.FloorToInt(PNNOLPKBHNQ - position.x + 350f);
			}
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x0000CAEC File Offset: 0x0000ACEC
		public void KLCQJDFCHGG(float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			this.HCQJIHONLLG(1700f, 796f, 543f, EMGIPNLQGJK, PIQMBELPJQQ, OQFDCGMDLKC);
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x0000CB06 File Offset: 0x0000AD06
		public void KNNMKOPQJID(float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			this.DELHPQMIBQJ(1253f, 1035f, 1906f, EMGIPNLQGJK, PIQMBELPJQQ, OQFDCGMDLKC);
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x0000CB20 File Offset: 0x0000AD20
		public void MHHFJFEEHGP(float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			this.CECJKCEDBQO(134f, 1342f, 1270f, EMGIPNLQGJK, PIQMBELPJQQ, OQFDCGMDLKC);
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x0000CB3A File Offset: 0x0000AD3A
		public void PKECBMHDEFG(float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			this.IQNFOEEFJKI(297f, 1646f, 1680f, EMGIPNLQGJK, PIQMBELPJQQ, OQFDCGMDLKC);
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x0000CB54 File Offset: 0x0000AD54
		public void PPGLBQDNCID(float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			this.CBBLLNEEOOH(354f, 938f, 1302f, EMGIPNLQGJK, PIQMBELPJQQ, OQFDCGMDLKC);
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x0000CB6E File Offset: 0x0000AD6E
		public void LBOQMCJGOLL(float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			this.HCQJIHONLLG(1278f, 367f, 66f, EMGIPNLQGJK, PIQMBELPJQQ, OQFDCGMDLKC);
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x000A892C File Offset: 0x000A6B2C
		public void CBBLLNEEOOH(float EGHLNPDHCLL, float EBIHBDMJJLI, float MIBFDQNFMIF, float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			float num = Mathf.Abs(EMGIPNLQGJK);
			float num2 = Mathf.Abs(PIQMBELPJQQ);
			float num3 = Mathf.Abs(OQFDCGMDLKC);
			if (num < num2 && num < num3)
			{
				this.MLEHNJBCBGD(EGHLNPDHCLL, EMGIPNLQGJK);
			}
			else if (num2 < num && num2 < num3)
			{
				this.MLEHNJBCBGD(EBIHBDMJJLI, PIQMBELPJQQ);
			}
			else
			{
				this.KODHLLDFKGO(MIBFDQNFMIF, OQFDCGMDLKC);
			}
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x000A8980 File Offset: 0x000A6B80
		public void BDLOPHJOLOB(float EGHLNPDHCLL, float EBIHBDMJJLI, float MIBFDQNFMIF, float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			float num = Mathf.Abs(EMGIPNLQGJK);
			float num2 = Mathf.Abs(PIQMBELPJQQ);
			float num3 = Mathf.Abs(OQFDCGMDLKC);
			if (num < num2 && num < num3)
			{
				this.MLEHNJBCBGD(EGHLNPDHCLL, EMGIPNLQGJK);
			}
			else if (num2 < num && num2 < num3)
			{
				this.KDBPHMJLPLI(EBIHBDMJJLI, PIQMBELPJQQ);
			}
			else
			{
				this.MLEHNJBCBGD(MIBFDQNFMIF, OQFDCGMDLKC);
			}
		}

		// Token: 0x06001801 RID: 6145 RVA: 0x000A89D4 File Offset: 0x000A6BD4
		public void LFQIMMBFNJH(float EGHLNPDHCLL, float EBIHBDMJJLI, float MIBFDQNFMIF, float EMGIPNLQGJK, float PIQMBELPJQQ, float OQFDCGMDLKC)
		{
			float num = Mathf.Abs(EMGIPNLQGJK);
			float num2 = Mathf.Abs(PIQMBELPJQQ);
			float num3 = Mathf.Abs(OQFDCGMDLKC);
			if (num < num2 && num < num3)
			{
				this.MLEHNJBCBGD(EGHLNPDHCLL, EMGIPNLQGJK);
			}
			else if (num2 < num && num2 < num3)
			{
				this.KDJODMLBQEB(EBIHBDMJJLI, PIQMBELPJQQ);
			}
			else
			{
				this.PJMIKDIEGMB(MIBFDQNFMIF, OQFDCGMDLKC);
			}
		}

		// Token: 0x040004BD RID: 1213
		public Transform target;

		// Token: 0x040004BE RID: 1214
		public float relative;

		// Token: 0x040004BF RID: 1215
		public int absolute;

		// Token: 0x040004C0 RID: 1216
		[NonSerialized]
		public BLMNBILNMOE rect;

		// Token: 0x040004C1 RID: 1217
		[NonSerialized]
		public Camera targetCam;
	}

	// Token: 0x020000C6 RID: 198
	public enum PCOFBQMMOOO
	{
		// Token: 0x040004C3 RID: 1219
		OnEnable,
		// Token: 0x040004C4 RID: 1220
		OnUpdate,
		// Token: 0x040004C5 RID: 1221
		OnStart
	}
}
