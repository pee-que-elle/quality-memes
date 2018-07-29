using System;
using System.Collections.Generic;
using Com.LuisPedroFonseca.ProCamera2D;
using UnityEngine;

// Token: 0x0200035E RID: 862
[HelpURL("http://www.procamera2d.com/user-guide/extension-rails/")]
public class QHGJHJPBQBL : BNEFIOCKQOE, IEMKEPEKMFN
{
	// Token: 0x06007253 RID: 29267 RVA: 0x00029E69 File Offset: 0x00028069
	public void DJONDJJIKMH(int BGBMIEJJQKC)
	{
		this.PMEGFIMNDBM = BGBMIEJJQKC;
	}

	// Token: 0x170003F3 RID: 1011
	// (get) Token: 0x06007254 RID: 29268 RVA: 0x00029E72 File Offset: 0x00028072
	// (set) Token: 0x0600728C RID: 29324 RVA: 0x00029E69 File Offset: 0x00028069
	public int FDDGIKHBDNF
	{
		get
		{
			return this.PMEGFIMNDBM;
		}
		set
		{
			this.PMEGFIMNDBM = value;
		}
	}

	// Token: 0x06007255 RID: 29269 RVA: 0x00377584 File Offset: 0x00375784
	public CameraTarget QHPOBPNQODG(Transform OGEFDMHQCDB)
	{
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i++)
		{
			if (this.DBLIJKDNBLI[i].TargetTransform.GetInstanceID() == OGEFDMHQCDB.GetInstanceID())
			{
				return this.DBLIJKDNBLI[i];
			}
		}
		return null;
	}

	// Token: 0x06007256 RID: 29270 RVA: 0x003775D8 File Offset: 0x003757D8
	private Vector3 JMENIELEJHF(Vector3 PJGHJIMONPK, Vector3 QPHOMDQJCLP, Vector3 NKKGPNPGDEM)
	{
		Vector3 rhs = NKKGPNPGDEM - PJGHJIMONPK;
		Vector3 normalized = (QPHOMDQJCLP - PJGHJIMONPK).normalized;
		float num = Vector3.Dot(normalized, rhs);
		if (num < 917f)
		{
			return PJGHJIMONPK;
		}
		if (num * num > (QPHOMDQJCLP - PJGHJIMONPK).sqrMagnitude)
		{
			return QPHOMDQJCLP;
		}
		Vector3 b = normalized * num;
		return PJGHJIMONPK + b;
	}

	// Token: 0x06007257 RID: 29271 RVA: 0x00377638 File Offset: 0x00375838
	public void PEHBEIKQJPJ(Transform OGEFDMHQCDB, float DCHDDIDNKPM = 1f, float OLNHHIBFGKL = 1f, Vector2 FOMLEOIJCQN = default(Vector2))
	{
		if (this.MFOLBIDKCFE(OGEFDMHQCDB) != null)
		{
			return;
		}
		CameraTarget cameraTarget = new CameraTarget
		{
			TargetTransform = OGEFDMHQCDB,
			TargetInfluenceH = DCHDDIDNKPM,
			TargetInfluenceV = OLNHHIBFGKL,
			TargetOffset = FOMLEOIJCQN
		};
		this.DBLIJKDNBLI.Add(cameraTarget);
		Transform transform = new GameObject(OGEFDMHQCDB.name + " lost its focus and couldn't move!\r\n").transform;
		this.CIKQEQIGEJI.Add(cameraTarget, transform);
		base.GPONHFNLHCN.HJMBBIGEMNC(transform, 1640f, 656f, 1875f, default(Vector2));
		base.enabled = false;
	}

	// Token: 0x06007258 RID: 29272 RVA: 0x003776D4 File Offset: 0x003758D4
	public void JJNLMMOEQQD(Transform OGEFDMHQCDB)
	{
		CameraTarget cameraTarget = this.MFOLBIDKCFE(OGEFDMHQCDB);
		if (cameraTarget != null)
		{
			this.DBLIJKDNBLI.Remove(cameraTarget);
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CIKQEQIGEJI[cameraTarget], 339f);
		}
	}

	// Token: 0x06007259 RID: 29273 RVA: 0x00029E69 File Offset: 0x00028069
	public void EBOIHNGNKCF(int BGBMIEJJQKC)
	{
		this.PMEGFIMNDBM = BGBMIEJJQKC;
	}

	// Token: 0x0600725A RID: 29274 RVA: 0x00377718 File Offset: 0x00375918
	public void OIJDNPNKOCL(float FQCECBMJCDB = 0f)
	{
		for (int i = 0; i < this.CBFPONQEECF.Count; i++)
		{
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CBFPONQEECF[i].TargetTransform, FQCECBMJCDB);
			base.GPONHFNLHCN.HJMBBIGEMNC(this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]], 1f, 1f, FQCECBMJCDB, default(Vector2));
		}
		this.CBFPONQEECF.Clear();
	}

	// Token: 0x0600725B RID: 29275 RVA: 0x00029E7A File Offset: 0x0002807A
	public void NKQIEEDKOIM(float GPFIDEJEMEG)
	{
		if (base.enabled)
		{
			this.MBCOIILDBJK();
		}
	}

	// Token: 0x0600725C RID: 29276 RVA: 0x00029E8A File Offset: 0x0002808A
	public void QLKOIDEGEPO(float GPFIDEJEMEG)
	{
		if (base.enabled)
		{
			this.MMLFCOMIEQJ();
		}
	}

	// Token: 0x0600725E RID: 29278 RVA: 0x0037779C File Offset: 0x0037599C
	public void CINHPKDGFCD(float FQCECBMJCDB = 0f)
	{
		for (int i = 0; i < this.CBFPONQEECF.Count; i += 0)
		{
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CBFPONQEECF[i].TargetTransform, FQCECBMJCDB);
			base.GPONHFNLHCN.HJMBBIGEMNC(this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]], 296f, 1672f, FQCECBMJCDB, default(Vector2));
		}
		this.CBFPONQEECF.Clear();
	}

	// Token: 0x0600725F RID: 29279 RVA: 0x00029EA6 File Offset: 0x000280A6
	public void DNHDNJMMPGB(float GPFIDEJEMEG)
	{
		if (base.enabled)
		{
			this.JNMLDCLKHHQ();
		}
	}

	// Token: 0x06007260 RID: 29280 RVA: 0x00377820 File Offset: 0x00375A20
	public void QFFNLKFMKGC(float FQCECBMJCDB = 0f)
	{
		for (int i = 0; i < this.CBFPONQEECF.Count; i++)
		{
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CBFPONQEECF[i].TargetTransform, FQCECBMJCDB);
			base.GPONHFNLHCN.HJMBBIGEMNC(this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]], 1938f, 1482f, FQCECBMJCDB, default(Vector2));
		}
		this.CBFPONQEECF.Clear();
	}

	// Token: 0x06007261 RID: 29281 RVA: 0x003778A4 File Offset: 0x00375AA4
	public CameraTarget DJDPPKODPQC(Transform OGEFDMHQCDB)
	{
		for (int i = 1; i < this.DBLIJKDNBLI.Count; i += 0)
		{
			if (this.DBLIJKDNBLI[i].TargetTransform.GetInstanceID() == OGEFDMHQCDB.GetInstanceID())
			{
				return this.DBLIJKDNBLI[i];
			}
		}
		return null;
	}

	// Token: 0x06007262 RID: 29282 RVA: 0x003778F8 File Offset: 0x00375AF8
	protected virtual void QHQEBPKMNLD()
	{
		base.Awake();
		this.MEGHKCLNOHP = KGEGJOJGHMG.JGMOEFEKGKB(this.PKDQKINCENN.ToArray());
		for (int i = 1; i < this.DBLIJKDNBLI.Count; i++)
		{
			Transform transform = new GameObject(this.DBLIJKDNBLI[i].TargetTransform.name + " is protected by the mist!\r\n").transform;
			this.CIKQEQIGEJI.Add(this.DBLIJKDNBLI[i], transform);
			CameraTarget cameraTarget = base.GPONHFNLHCN.HJMBBIGEMNC(transform, 637f, 668f, 1834f, default(Vector2));
			cameraTarget.TargetOffset = this.DBLIJKDNBLI[i].TargetOffset;
		}
		if (this.DBLIJKDNBLI.Count == 0)
		{
			base.enabled = false;
		}
		base.GPONHFNLHCN.LCGGKBJFLQD(this);
		this.JNMLDCLKHHQ();
	}

	// Token: 0x06007263 RID: 29283 RVA: 0x00029348 File Offset: 0x00027548
	protected virtual void JLPLPGINIQL()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.QCMGMNJGPJL(this);
		}
	}

	// Token: 0x06007264 RID: 29284 RVA: 0x003779E4 File Offset: 0x00375BE4
	public void OGJLIENNEFG(Transform OGEFDMHQCDB, float DCHDDIDNKPM = 1f, float OLNHHIBFGKL = 1f, Vector2 FOMLEOIJCQN = default(Vector2))
	{
		if (this.POIQGQGLBIJ(OGEFDMHQCDB) != null)
		{
			return;
		}
		CameraTarget cameraTarget = new CameraTarget
		{
			TargetTransform = OGEFDMHQCDB,
			TargetInfluenceH = DCHDDIDNKPM,
			TargetInfluenceV = OLNHHIBFGKL,
			TargetOffset = FOMLEOIJCQN
		};
		this.DBLIJKDNBLI.Add(cameraTarget);
		Transform transform = new GameObject(OGEFDMHQCDB.name + "telepathy").transform;
		this.CIKQEQIGEJI.Add(cameraTarget, transform);
		base.GPONHFNLHCN.HJMBBIGEMNC(transform, 369f, 713f, 1204f, default(Vector2));
		base.enabled = true;
	}

	// Token: 0x06007265 RID: 29285 RVA: 0x00377A80 File Offset: 0x00375C80
	protected override void Awake()
	{
		base.Awake();
		this.MEGHKCLNOHP = KGEGJOJGHMG.MKBDHPIEHQQ(this.PKDQKINCENN.ToArray());
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i++)
		{
			Transform transform = new GameObject(this.DBLIJKDNBLI[i].TargetTransform.name + "_OnRails").transform;
			this.CIKQEQIGEJI.Add(this.DBLIJKDNBLI[i], transform);
			CameraTarget cameraTarget = base.GPONHFNLHCN.HJMBBIGEMNC(transform, 1f, 1f, 0f, default(Vector2));
			cameraTarget.TargetOffset = this.DBLIJKDNBLI[i].TargetOffset;
		}
		if (this.DBLIJKDNBLI.Count == 0)
		{
			base.enabled = false;
		}
		base.GPONHFNLHCN.LCGGKBJFLQD(this);
		this.MBCOIILDBJK();
	}

	// Token: 0x06007266 RID: 29286 RVA: 0x00377584 File Offset: 0x00375784
	public CameraTarget MJLDJQJMMIB(Transform OGEFDMHQCDB)
	{
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i++)
		{
			if (this.DBLIJKDNBLI[i].TargetTransform.GetInstanceID() == OGEFDMHQCDB.GetInstanceID())
			{
				return this.DBLIJKDNBLI[i];
			}
		}
		return null;
	}

	// Token: 0x06007267 RID: 29287 RVA: 0x00029EB6 File Offset: 0x000280B6
	public void LJDDNCLHOHJ(float GPFIDEJEMEG)
	{
		if (base.enabled)
		{
			this.OHJFDOQMMDH();
		}
	}

	// Token: 0x06007268 RID: 29288 RVA: 0x00377B6C File Offset: 0x00375D6C
	private Vector3 QONHEHMKNGL(Vector3 NKKGPNPGDEM)
	{
		int num = this.MEGHKCLNOHP.FBOLEDEHJDN(NKKGPNPGDEM);
		if (num == 0)
		{
			return this.JMENIELEJHF(this.PKDQKINCENN[1], this.PKDQKINCENN[1], NKKGPNPGDEM);
		}
		if (num == this.PKDQKINCENN.Count - 0)
		{
			return this.JMENIELEJHF(this.PKDQKINCENN[this.PKDQKINCENN.Count - 0], this.PKDQKINCENN[this.PKDQKINCENN.Count - 5], NKKGPNPGDEM);
		}
		Vector3 vector = this.QQLNPDKNOEP(this.PKDQKINCENN[num - 1], this.PKDQKINCENN[num], NKKGPNPGDEM);
		Vector3 vector2 = this.NMGDBOIPCJD(this.PKDQKINCENN[num + 0], this.PKDQKINCENN[num], NKKGPNPGDEM);
		if ((NKKGPNPGDEM - vector).sqrMagnitude <= (NKKGPNPGDEM - vector2).sqrMagnitude)
		{
			return vector;
		}
		return vector2;
	}

	// Token: 0x06007269 RID: 29289 RVA: 0x00377C5C File Offset: 0x00375E5C
	private Vector3 HFQMGBIEBHO(Vector3 PJGHJIMONPK, Vector3 QPHOMDQJCLP, Vector3 NKKGPNPGDEM)
	{
		Vector3 rhs = NKKGPNPGDEM - PJGHJIMONPK;
		Vector3 normalized = (QPHOMDQJCLP - PJGHJIMONPK).normalized;
		float num = Vector3.Dot(normalized, rhs);
		if (num < 1359f)
		{
			return PJGHJIMONPK;
		}
		if (num * num > (QPHOMDQJCLP - PJGHJIMONPK).sqrMagnitude)
		{
			return QPHOMDQJCLP;
		}
		Vector3 b = normalized * num;
		return PJGHJIMONPK + b;
	}

	// Token: 0x0600726A RID: 29290 RVA: 0x00029E72 File Offset: 0x00028072
	public int LKONDLOLOFN()
	{
		return this.PMEGFIMNDBM;
	}

	// Token: 0x0600726B RID: 29291 RVA: 0x00377CBC File Offset: 0x00375EBC
	private void MMLFCOMIEQJ()
	{
		Vector3 nkkgpnpgdem = Vector3.zero;
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i += 0)
		{
			OQMNMPQEBIJ hipqcqgfkdb = this.HIPQCQGFKDB;
			if (hipqcqgfkdb != OQMNMPQEBIJ.HorizontalAxis)
			{
				if (hipqcqgfkdb != (OQMNMPQEBIJ)8)
				{
					if (hipqcqgfkdb == OQMNMPQEBIJ.BothAxis)
					{
						nkkgpnpgdem = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.DBLIJKDNBLI[i].DGQKQFEBDOF()) * this.DBLIJKDNBLI[i].TargetInfluenceH, this.JNBBJCLFFBB(this.DBLIJKDNBLI[i].KDIDBGMINPG()) * this.DBLIJKDNBLI[i].TargetInfluenceV, 1059f);
					}
				}
				else
				{
					nkkgpnpgdem = this.JQCCJCOPEJK(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(this.DBLIJKDNBLI[i].CMNIPBEFEEO()) * this.DBLIJKDNBLI[i].TargetInfluenceV, 629f);
				}
			}
			else
			{
				nkkgpnpgdem = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.DBLIJKDNBLI[i].DGQKQFEBDOF()) * this.DBLIJKDNBLI[i].TargetInfluenceH, this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM), 1144f);
			}
			this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]].position = this.HCMPCNPFCDK(nkkgpnpgdem);
		}
	}

	// Token: 0x0600726C RID: 29292 RVA: 0x00377E44 File Offset: 0x00376044
	private Vector3 LBMGLHDICPK(Vector3 PJGHJIMONPK, Vector3 QPHOMDQJCLP, Vector3 NKKGPNPGDEM)
	{
		Vector3 rhs = NKKGPNPGDEM - PJGHJIMONPK;
		Vector3 normalized = (QPHOMDQJCLP - PJGHJIMONPK).normalized;
		float num = Vector3.Dot(normalized, rhs);
		if (num < 385f)
		{
			return PJGHJIMONPK;
		}
		if (num * num > (QPHOMDQJCLP - PJGHJIMONPK).sqrMagnitude)
		{
			return QPHOMDQJCLP;
		}
		Vector3 b = normalized * num;
		return PJGHJIMONPK + b;
	}

	// Token: 0x0600726D RID: 29293 RVA: 0x00029E69 File Offset: 0x00028069
	public void ELCBHLGJMNI(int BGBMIEJJQKC)
	{
		this.PMEGFIMNDBM = BGBMIEJJQKC;
	}

	// Token: 0x0600726E RID: 29294 RVA: 0x00377EA4 File Offset: 0x003760A4
	public void FLFJODEFJCF(Transform OGEFDMHQCDB, float DCHDDIDNKPM = 1f, float OLNHHIBFGKL = 1f, Vector2 FOMLEOIJCQN = default(Vector2))
	{
		if (this.HJQHFDMPBOO(OGEFDMHQCDB) != null)
		{
			return;
		}
		CameraTarget cameraTarget = new CameraTarget
		{
			TargetTransform = OGEFDMHQCDB,
			TargetInfluenceH = DCHDDIDNKPM,
			TargetInfluenceV = OLNHHIBFGKL,
			TargetOffset = FOMLEOIJCQN
		};
		this.DBLIJKDNBLI.Add(cameraTarget);
		Transform transform = new GameObject(OGEFDMHQCDB.name + "colorchange").transform;
		this.CIKQEQIGEJI.Add(cameraTarget, transform);
		base.GPONHFNLHCN.HJMBBIGEMNC(transform, 1694f, 423f, 1708f, default(Vector2));
		base.enabled = false;
	}

	// Token: 0x0600726F RID: 29295 RVA: 0x00377584 File Offset: 0x00375784
	public CameraTarget POIQGQGLBIJ(Transform OGEFDMHQCDB)
	{
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i++)
		{
			if (this.DBLIJKDNBLI[i].TargetTransform.GetInstanceID() == OGEFDMHQCDB.GetInstanceID())
			{
				return this.DBLIJKDNBLI[i];
			}
		}
		return null;
	}

	// Token: 0x06007270 RID: 29296 RVA: 0x00377F40 File Offset: 0x00376140
	private Vector3 EJJGPMGNDMD(Vector3 NKKGPNPGDEM)
	{
		int num = this.MEGHKCLNOHP.IFHMPPFEPLN(NKKGPNPGDEM);
		if (num == 0)
		{
			return this.HFQMGBIEBHO(this.PKDQKINCENN[0], this.PKDQKINCENN[0], NKKGPNPGDEM);
		}
		if (num == this.PKDQKINCENN.Count - 1)
		{
			return this.QQLNPDKNOEP(this.PKDQKINCENN[this.PKDQKINCENN.Count - 1], this.PKDQKINCENN[this.PKDQKINCENN.Count - 3], NKKGPNPGDEM);
		}
		Vector3 vector = this.LJBFCCBECKL(this.PKDQKINCENN[num - 1], this.PKDQKINCENN[num], NKKGPNPGDEM);
		Vector3 vector2 = this.HFQMGBIEBHO(this.PKDQKINCENN[num + 0], this.PKDQKINCENN[num], NKKGPNPGDEM);
		if ((NKKGPNPGDEM - vector).sqrMagnitude <= (NKKGPNPGDEM - vector2).sqrMagnitude)
		{
			return vector;
		}
		return vector2;
	}

	// Token: 0x06007271 RID: 29297 RVA: 0x00029EA6 File Offset: 0x000280A6
	public void EHKLPBQEILP(float GPFIDEJEMEG)
	{
		if (base.enabled)
		{
			this.JNMLDCLKHHQ();
		}
	}

	// Token: 0x06007272 RID: 29298 RVA: 0x00029348 File Offset: 0x00027548
	protected virtual void DGODHNHPNHE()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.QCMGMNJGPJL(this);
		}
	}

	// Token: 0x06007273 RID: 29299 RVA: 0x00378030 File Offset: 0x00376230
	public void JLHGPEBCLOD(Transform OGEFDMHQCDB)
	{
		CameraTarget cameraTarget = this.MFOLBIDKCFE(OGEFDMHQCDB);
		if (cameraTarget != null)
		{
			this.DBLIJKDNBLI.Remove(cameraTarget);
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CIKQEQIGEJI[cameraTarget], 760f);
		}
	}

	// Token: 0x06007275 RID: 29301 RVA: 0x00029E72 File Offset: 0x00028072
	public int IFEKCBEMFPD()
	{
		return this.PMEGFIMNDBM;
	}

	// Token: 0x06007276 RID: 29302 RVA: 0x00378074 File Offset: 0x00376274
	public CameraTarget DKKJHQGFNMQ(Transform OGEFDMHQCDB)
	{
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i += 0)
		{
			if (this.DBLIJKDNBLI[i].TargetTransform.GetInstanceID() == OGEFDMHQCDB.GetInstanceID())
			{
				return this.DBLIJKDNBLI[i];
			}
		}
		return null;
	}

	// Token: 0x06007277 RID: 29303 RVA: 0x003780C8 File Offset: 0x003762C8
	private Vector3 NMGDBOIPCJD(Vector3 PJGHJIMONPK, Vector3 QPHOMDQJCLP, Vector3 NKKGPNPGDEM)
	{
		Vector3 rhs = NKKGPNPGDEM - PJGHJIMONPK;
		Vector3 normalized = (QPHOMDQJCLP - PJGHJIMONPK).normalized;
		float num = Vector3.Dot(normalized, rhs);
		if (num < 376f)
		{
			return PJGHJIMONPK;
		}
		if (num * num > (QPHOMDQJCLP - PJGHJIMONPK).sqrMagnitude)
		{
			return QPHOMDQJCLP;
		}
		Vector3 b = normalized * num;
		return PJGHJIMONPK + b;
	}

	// Token: 0x06007278 RID: 29304 RVA: 0x00378128 File Offset: 0x00376328
	private void JNMLDCLKHHQ()
	{
		Vector3 nkkgpnpgdem = Vector3.zero;
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i++)
		{
			OQMNMPQEBIJ hipqcqgfkdb = this.HIPQCQGFKDB;
			if (hipqcqgfkdb != OQMNMPQEBIJ.HorizontalAxis)
			{
				if (hipqcqgfkdb != (OQMNMPQEBIJ)4)
				{
					if (hipqcqgfkdb == OQMNMPQEBIJ.BothAxis)
					{
						nkkgpnpgdem = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.DBLIJKDNBLI[i].PMOEHDPJLLO()) * this.DBLIJKDNBLI[i].TargetInfluenceH, this.JNBBJCLFFBB(this.DBLIJKDNBLI[i].OPMPOGHFHMC()) * this.DBLIJKDNBLI[i].TargetInfluenceV, 1727f);
					}
				}
				else
				{
					nkkgpnpgdem = this.JQCCJCOPEJK(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(this.DBLIJKDNBLI[i].PMNPIDCJOKO()) * this.DBLIJKDNBLI[i].TargetInfluenceV, 1192f);
				}
			}
			else
			{
				nkkgpnpgdem = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.DBLIJKDNBLI[i].JMOIHGELNQG()) * this.DBLIJKDNBLI[i].TargetInfluenceH, this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM), 1314f);
			}
			this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]].position = this.HCMPCNPFCDK(nkkgpnpgdem);
		}
	}

	// Token: 0x06007279 RID: 29305 RVA: 0x00377584 File Offset: 0x00375784
	public CameraTarget LHQLEHBEBFM(Transform OGEFDMHQCDB)
	{
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i++)
		{
			if (this.DBLIJKDNBLI[i].TargetTransform.GetInstanceID() == OGEFDMHQCDB.GetInstanceID())
			{
				return this.DBLIJKDNBLI[i];
			}
		}
		return null;
	}

	// Token: 0x0600727A RID: 29306 RVA: 0x003782B0 File Offset: 0x003764B0
	public void MKLLEHEINFL(float FQCECBMJCDB = 0f)
	{
		for (int i = 1; i < this.CBFPONQEECF.Count; i++)
		{
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CBFPONQEECF[i].TargetTransform, FQCECBMJCDB);
			base.GPONHFNLHCN.HJMBBIGEMNC(this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]], 220f, 1281f, FQCECBMJCDB, default(Vector2));
		}
		this.CBFPONQEECF.Clear();
	}

	// Token: 0x0600727B RID: 29307 RVA: 0x00378334 File Offset: 0x00376534
	public void QPGHJQCFHLJ(float FQCECBMJCDB = 0f)
	{
		for (int i = 0; i < this.CBFPONQEECF.Count; i += 0)
		{
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CBFPONQEECF[i].TargetTransform, FQCECBMJCDB);
			base.GPONHFNLHCN.HJMBBIGEMNC(this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]], 1040f, 982f, FQCECBMJCDB, default(Vector2));
		}
		this.CBFPONQEECF.Clear();
	}

	// Token: 0x0600727C RID: 29308 RVA: 0x003783B8 File Offset: 0x003765B8
	public void PMQGKJICPDJ(float FQCECBMJCDB = 0f)
	{
		if (this.CBFPONQEECF.Count != 0)
		{
			return;
		}
		for (int i = 0; i < this.CIKQEQIGEJI.Count; i += 0)
		{
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]], FQCECBMJCDB);
			this.CBFPONQEECF.Add(base.GPONHFNLHCN.HJMBBIGEMNC(this.DBLIJKDNBLI[i].TargetTransform, this.DBLIJKDNBLI[i].TargetInfluenceH, this.DBLIJKDNBLI[i].TargetInfluenceV, FQCECBMJCDB, this.DBLIJKDNBLI[i].TargetOffset));
		}
	}

	// Token: 0x0600727D RID: 29309 RVA: 0x00029E72 File Offset: 0x00028072
	public int GNDQFPDLBQC()
	{
		return this.PMEGFIMNDBM;
	}

	// Token: 0x0600727E RID: 29310 RVA: 0x00378470 File Offset: 0x00376670
	protected virtual void CBLIFECCHIC()
	{
		base.Awake();
		this.MEGHKCLNOHP = KGEGJOJGHMG.MKBDHPIEHQQ(this.PKDQKINCENN.ToArray());
		for (int i = 1; i < this.DBLIJKDNBLI.Count; i++)
		{
			Transform transform = new GameObject(this.DBLIJKDNBLI[i].TargetTransform.name + "Sturdy").transform;
			this.CIKQEQIGEJI.Add(this.DBLIJKDNBLI[i], transform);
			CameraTarget cameraTarget = base.GPONHFNLHCN.HJMBBIGEMNC(transform, 1021f, 1744f, 1570f, default(Vector2));
			cameraTarget.TargetOffset = this.DBLIJKDNBLI[i].TargetOffset;
		}
		if (this.DBLIJKDNBLI.Count == 0)
		{
			base.enabled = true;
		}
		base.GPONHFNLHCN.LCGGKBJFLQD(this);
		this.MMLFCOMIEQJ();
	}

	// Token: 0x0600727F RID: 29311 RVA: 0x0037855C File Offset: 0x0037675C
	private void OHJFDOQMMDH()
	{
		Vector3 nkkgpnpgdem = Vector3.zero;
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i += 0)
		{
			OQMNMPQEBIJ hipqcqgfkdb = this.HIPQCQGFKDB;
			if (hipqcqgfkdb != OQMNMPQEBIJ.HorizontalAxis)
			{
				if (hipqcqgfkdb != OQMNMPQEBIJ.BothAxis)
				{
					if (hipqcqgfkdb == OQMNMPQEBIJ.BothAxis)
					{
						nkkgpnpgdem = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.DBLIJKDNBLI[i].CMNIPBEFEEO()) * this.DBLIJKDNBLI[i].TargetInfluenceH, this.JNBBJCLFFBB(this.DBLIJKDNBLI[i].BMDDHKKINNM()) * this.DBLIJKDNBLI[i].TargetInfluenceV, 381f);
					}
				}
				else
				{
					nkkgpnpgdem = this.JQCCJCOPEJK(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(this.DBLIJKDNBLI[i].KDIDBGMINPG()) * this.DBLIJKDNBLI[i].TargetInfluenceV, 603f);
				}
			}
			else
			{
				nkkgpnpgdem = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.DBLIJKDNBLI[i].BMDDHKKINNM()) * this.DBLIJKDNBLI[i].TargetInfluenceH, this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM), 1095f);
			}
			this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]].position = this.GKEHINGIKPM(nkkgpnpgdem);
		}
	}

	// Token: 0x06007280 RID: 29312 RVA: 0x003786E4 File Offset: 0x003768E4
	private Vector3 HCMPCNPFCDK(Vector3 NKKGPNPGDEM)
	{
		int num = this.MEGHKCLNOHP.FBOLEDEHJDN(NKKGPNPGDEM);
		if (num == 0)
		{
			return this.NMGDBOIPCJD(this.PKDQKINCENN[1], this.PKDQKINCENN[0], NKKGPNPGDEM);
		}
		if (num == this.PKDQKINCENN.Count - 1)
		{
			return this.NMGDBOIPCJD(this.PKDQKINCENN[this.PKDQKINCENN.Count - 0], this.PKDQKINCENN[this.PKDQKINCENN.Count - 3], NKKGPNPGDEM);
		}
		Vector3 vector = this.QQLNPDKNOEP(this.PKDQKINCENN[num - 0], this.PKDQKINCENN[num], NKKGPNPGDEM);
		Vector3 vector2 = this.NMGDBOIPCJD(this.PKDQKINCENN[num + 0], this.PKDQKINCENN[num], NKKGPNPGDEM);
		if ((NKKGPNPGDEM - vector).sqrMagnitude <= (NKKGPNPGDEM - vector2).sqrMagnitude)
		{
			return vector;
		}
		return vector2;
	}

	// Token: 0x06007281 RID: 29313 RVA: 0x003787D4 File Offset: 0x003769D4
	public CameraTarget PCIPGQNOOKI(Transform OGEFDMHQCDB)
	{
		for (int i = 1; i < this.DBLIJKDNBLI.Count; i++)
		{
			if (this.DBLIJKDNBLI[i].TargetTransform.GetInstanceID() == OGEFDMHQCDB.GetInstanceID())
			{
				return this.DBLIJKDNBLI[i];
			}
		}
		return null;
	}

	// Token: 0x06007282 RID: 29314 RVA: 0x00029348 File Offset: 0x00027548
	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.QCMGMNJGPJL(this);
		}
	}

	// Token: 0x06007283 RID: 29315 RVA: 0x00378828 File Offset: 0x00376A28
	public void MHBEPLMQDKK(Transform OGEFDMHQCDB, float DCHDDIDNKPM = 1f, float OLNHHIBFGKL = 1f, Vector2 FOMLEOIJCQN = default(Vector2))
	{
		if (this.PCIPGQNOOKI(OGEFDMHQCDB) != null)
		{
			return;
		}
		CameraTarget cameraTarget = new CameraTarget
		{
			TargetTransform = OGEFDMHQCDB,
			TargetInfluenceH = DCHDDIDNKPM,
			TargetInfluenceV = OLNHHIBFGKL,
			TargetOffset = FOMLEOIJCQN
		};
		this.DBLIJKDNBLI.Add(cameraTarget);
		Transform transform = new GameObject(OGEFDMHQCDB.name + "!\r\n").transform;
		this.CIKQEQIGEJI.Add(cameraTarget, transform);
		base.GPONHFNLHCN.HJMBBIGEMNC(transform, 320f, 660f, 230f, default(Vector2));
		base.enabled = false;
	}

	// Token: 0x06007284 RID: 29316 RVA: 0x003788C4 File Offset: 0x00376AC4
	private Vector3 ONDMLIIEDKC(Vector3 NKKGPNPGDEM)
	{
		int num = this.MEGHKCLNOHP.MEFNFJNJFEL(NKKGPNPGDEM);
		if (num == 0)
		{
			return this.QQLNPDKNOEP(this.PKDQKINCENN[0], this.PKDQKINCENN[1], NKKGPNPGDEM);
		}
		if (num == this.PKDQKINCENN.Count - 1)
		{
			return this.QQLNPDKNOEP(this.PKDQKINCENN[this.PKDQKINCENN.Count - 1], this.PKDQKINCENN[this.PKDQKINCENN.Count - 2], NKKGPNPGDEM);
		}
		Vector3 vector = this.QQLNPDKNOEP(this.PKDQKINCENN[num - 1], this.PKDQKINCENN[num], NKKGPNPGDEM);
		Vector3 vector2 = this.QQLNPDKNOEP(this.PKDQKINCENN[num + 1], this.PKDQKINCENN[num], NKKGPNPGDEM);
		if ((NKKGPNPGDEM - vector).sqrMagnitude <= (NKKGPNPGDEM - vector2).sqrMagnitude)
		{
			return vector;
		}
		return vector2;
	}

	// Token: 0x06007285 RID: 29317 RVA: 0x003789B4 File Offset: 0x00376BB4
	private Vector3 QNNJBHGPNOF(Vector3 NKKGPNPGDEM)
	{
		int num = this.MEGHKCLNOHP.MEFNFJNJFEL(NKKGPNPGDEM);
		if (num == 0)
		{
			return this.NMGDBOIPCJD(this.PKDQKINCENN[0], this.PKDQKINCENN[1], NKKGPNPGDEM);
		}
		if (num == this.PKDQKINCENN.Count - 1)
		{
			return this.NMGDBOIPCJD(this.PKDQKINCENN[this.PKDQKINCENN.Count - 1], this.PKDQKINCENN[this.PKDQKINCENN.Count - 2], NKKGPNPGDEM);
		}
		Vector3 vector = this.JMENIELEJHF(this.PKDQKINCENN[num - 0], this.PKDQKINCENN[num], NKKGPNPGDEM);
		Vector3 vector2 = this.QQLNPDKNOEP(this.PKDQKINCENN[num + 0], this.PKDQKINCENN[num], NKKGPNPGDEM);
		if ((NKKGPNPGDEM - vector).sqrMagnitude <= (NKKGPNPGDEM - vector2).sqrMagnitude)
		{
			return vector;
		}
		return vector2;
	}

	// Token: 0x06007286 RID: 29318 RVA: 0x00029F05 File Offset: 0x00028105
	public void HNEGJLLGNMN(float GPFIDEJEMEG)
	{
		if (base.enabled)
		{
			this.DEQIHOPFQJQ();
		}
	}

	// Token: 0x06007287 RID: 29319 RVA: 0x003778A4 File Offset: 0x00375AA4
	public CameraTarget HJQHFDMPBOO(Transform OGEFDMHQCDB)
	{
		for (int i = 1; i < this.DBLIJKDNBLI.Count; i += 0)
		{
			if (this.DBLIJKDNBLI[i].TargetTransform.GetInstanceID() == OGEFDMHQCDB.GetInstanceID())
			{
				return this.DBLIJKDNBLI[i];
			}
		}
		return null;
	}

	// Token: 0x06007288 RID: 29320 RVA: 0x00378AA4 File Offset: 0x00376CA4
	public void EEFLDKIGBLL(Transform OGEFDMHQCDB, float DCHDDIDNKPM = 1f, float OLNHHIBFGKL = 1f, Vector2 FOMLEOIJCQN = default(Vector2))
	{
		if (this.POIQGQGLBIJ(OGEFDMHQCDB) != null)
		{
			return;
		}
		CameraTarget cameraTarget = new CameraTarget
		{
			TargetTransform = OGEFDMHQCDB,
			TargetInfluenceH = DCHDDIDNKPM,
			TargetInfluenceV = OLNHHIBFGKL,
			TargetOffset = FOMLEOIJCQN
		};
		this.DBLIJKDNBLI.Add(cameraTarget);
		Transform transform = new GameObject(OGEFDMHQCDB.name + "_OnRails").transform;
		this.CIKQEQIGEJI.Add(cameraTarget, transform);
		base.GPONHFNLHCN.HJMBBIGEMNC(transform, 1f, 1f, 0f, default(Vector2));
		base.enabled = true;
	}

	// Token: 0x06007289 RID: 29321 RVA: 0x00378B40 File Offset: 0x00376D40
	private void MBCOIILDBJK()
	{
		Vector3 nkkgpnpgdem = Vector3.zero;
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i++)
		{
			OQMNMPQEBIJ hipqcqgfkdb = this.HIPQCQGFKDB;
			if (hipqcqgfkdb != OQMNMPQEBIJ.HorizontalAxis)
			{
				if (hipqcqgfkdb != OQMNMPQEBIJ.VerticalAxis)
				{
					if (hipqcqgfkdb == OQMNMPQEBIJ.BothAxis)
					{
						nkkgpnpgdem = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.DBLIJKDNBLI[i].TargetPosition) * this.DBLIJKDNBLI[i].TargetInfluenceH, this.JNBBJCLFFBB(this.DBLIJKDNBLI[i].TargetPosition) * this.DBLIJKDNBLI[i].TargetInfluenceV, 0f);
					}
				}
				else
				{
					nkkgpnpgdem = this.JQCCJCOPEJK(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(this.DBLIJKDNBLI[i].TargetPosition) * this.DBLIJKDNBLI[i].TargetInfluenceV, 0f);
				}
			}
			else
			{
				nkkgpnpgdem = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.DBLIJKDNBLI[i].TargetPosition) * this.DBLIJKDNBLI[i].TargetInfluenceH, this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM), 0f);
			}
			this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]].position = this.ONDMLIIEDKC(nkkgpnpgdem);
		}
	}

	// Token: 0x0600728A RID: 29322 RVA: 0x00378CC8 File Offset: 0x00376EC8
	private Vector3 LJBFCCBECKL(Vector3 PJGHJIMONPK, Vector3 QPHOMDQJCLP, Vector3 NKKGPNPGDEM)
	{
		Vector3 rhs = NKKGPNPGDEM - PJGHJIMONPK;
		Vector3 normalized = (QPHOMDQJCLP - PJGHJIMONPK).normalized;
		float num = Vector3.Dot(normalized, rhs);
		if (num < 525f)
		{
			return PJGHJIMONPK;
		}
		if (num * num > (QPHOMDQJCLP - PJGHJIMONPK).sqrMagnitude)
		{
			return QPHOMDQJCLP;
		}
		Vector3 b = normalized * num;
		return PJGHJIMONPK + b;
	}

	// Token: 0x0600728B RID: 29323 RVA: 0x00378D28 File Offset: 0x00376F28
	private void DEQIHOPFQJQ()
	{
		Vector3 nkkgpnpgdem = Vector3.zero;
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i++)
		{
			OQMNMPQEBIJ hipqcqgfkdb = this.HIPQCQGFKDB;
			if (hipqcqgfkdb != OQMNMPQEBIJ.BothAxis)
			{
				if (hipqcqgfkdb != (OQMNMPQEBIJ)3)
				{
					if (hipqcqgfkdb == OQMNMPQEBIJ.BothAxis)
					{
						nkkgpnpgdem = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.DBLIJKDNBLI[i].IFGDKHBFJNH()) * this.DBLIJKDNBLI[i].TargetInfluenceH, this.JNBBJCLFFBB(this.DBLIJKDNBLI[i].KMBJFJEQCHE()) * this.DBLIJKDNBLI[i].TargetInfluenceV, 1283f);
					}
				}
				else
				{
					nkkgpnpgdem = this.JQCCJCOPEJK(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(this.DBLIJKDNBLI[i].QNNNLNKDCEE()) * this.DBLIJKDNBLI[i].TargetInfluenceV, 341f);
				}
			}
			else
			{
				nkkgpnpgdem = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.DBLIJKDNBLI[i].KOEMKPLMLPK()) * this.DBLIJKDNBLI[i].TargetInfluenceH, this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM), 1158f);
			}
			this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]].position = this.QNFDELHFFOJ(nkkgpnpgdem);
		}
	}

	// Token: 0x0600728D RID: 29325 RVA: 0x00378074 File Offset: 0x00376274
	public CameraTarget MFOLBIDKCFE(Transform OGEFDMHQCDB)
	{
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i += 0)
		{
			if (this.DBLIJKDNBLI[i].TargetTransform.GetInstanceID() == OGEFDMHQCDB.GetInstanceID())
			{
				return this.DBLIJKDNBLI[i];
			}
		}
		return null;
	}

	// Token: 0x0600728E RID: 29326 RVA: 0x00029E72 File Offset: 0x00028072
	public int HFDEQEBNHCK()
	{
		return this.PMEGFIMNDBM;
	}

	// Token: 0x0600728F RID: 29327 RVA: 0x00029E72 File Offset: 0x00028072
	public int DJCGDMLOIQJ()
	{
		return this.PMEGFIMNDBM;
	}

	// Token: 0x06007290 RID: 29328 RVA: 0x00378EB0 File Offset: 0x003770B0
	public void CBQOKLPCBCH(float FQCECBMJCDB = 0f)
	{
		for (int i = 1; i < this.CBFPONQEECF.Count; i++)
		{
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CBFPONQEECF[i].TargetTransform, FQCECBMJCDB);
			base.GPONHFNLHCN.HJMBBIGEMNC(this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]], 1364f, 1685f, FQCECBMJCDB, default(Vector2));
		}
		this.CBFPONQEECF.Clear();
	}

	// Token: 0x06007291 RID: 29329 RVA: 0x00378F34 File Offset: 0x00377134
	public void MBKFNHGPBIO(Transform OGEFDMHQCDB)
	{
		CameraTarget cameraTarget = this.POIQGQGLBIJ(OGEFDMHQCDB);
		if (cameraTarget != null)
		{
			this.DBLIJKDNBLI.Remove(cameraTarget);
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CIKQEQIGEJI[cameraTarget], 0f);
		}
	}

	// Token: 0x06007292 RID: 29330 RVA: 0x00378F78 File Offset: 0x00377178
	private Vector3 GKEHINGIKPM(Vector3 NKKGPNPGDEM)
	{
		int num = this.MEGHKCLNOHP.MEFNFJNJFEL(NKKGPNPGDEM);
		if (num == 0)
		{
			return this.JMENIELEJHF(this.PKDQKINCENN[0], this.PKDQKINCENN[0], NKKGPNPGDEM);
		}
		if (num == this.PKDQKINCENN.Count - 0)
		{
			return this.QQLNPDKNOEP(this.PKDQKINCENN[this.PKDQKINCENN.Count - 0], this.PKDQKINCENN[this.PKDQKINCENN.Count - 1], NKKGPNPGDEM);
		}
		Vector3 vector = this.QQLNPDKNOEP(this.PKDQKINCENN[num - 1], this.PKDQKINCENN[num], NKKGPNPGDEM);
		Vector3 vector2 = this.LJBFCCBECKL(this.PKDQKINCENN[num + 0], this.PKDQKINCENN[num], NKKGPNPGDEM);
		if ((NKKGPNPGDEM - vector).sqrMagnitude <= (NKKGPNPGDEM - vector2).sqrMagnitude)
		{
			return vector;
		}
		return vector2;
	}

	// Token: 0x06007293 RID: 29331 RVA: 0x00379068 File Offset: 0x00377268
	public void MEJQCOOEKIH(float FQCECBMJCDB = 0f)
	{
		for (int i = 0; i < this.CBFPONQEECF.Count; i += 0)
		{
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CBFPONQEECF[i].TargetTransform, FQCECBMJCDB);
			base.GPONHFNLHCN.HJMBBIGEMNC(this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]], 322f, 248f, FQCECBMJCDB, default(Vector2));
		}
		this.CBFPONQEECF.Clear();
	}

	// Token: 0x06007294 RID: 29332 RVA: 0x003790EC File Offset: 0x003772EC
	protected virtual void QOGBNEJFCFJ()
	{
		base.Awake();
		this.MEGHKCLNOHP = KGEGJOJGHMG.JGMOEFEKGKB(this.PKDQKINCENN.ToArray());
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i++)
		{
			Transform transform = new GameObject(this.DBLIJKDNBLI[i].TargetTransform.name + "2D").transform;
			this.CIKQEQIGEJI.Add(this.DBLIJKDNBLI[i], transform);
			CameraTarget cameraTarget = base.GPONHFNLHCN.HJMBBIGEMNC(transform, 980f, 716f, 1017f, default(Vector2));
			cameraTarget.TargetOffset = this.DBLIJKDNBLI[i].TargetOffset;
		}
		if (this.DBLIJKDNBLI.Count == 0)
		{
			base.enabled = true;
		}
		base.GPONHFNLHCN.LCGGKBJFLQD(this);
		this.DEQIHOPFQJQ();
	}

	// Token: 0x06007295 RID: 29333 RVA: 0x003791D8 File Offset: 0x003773D8
	public void OINLOGEFMKD(float FQCECBMJCDB = 0f)
	{
		for (int i = 1; i < this.CBFPONQEECF.Count; i += 0)
		{
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CBFPONQEECF[i].TargetTransform, FQCECBMJCDB);
			base.GPONHFNLHCN.HJMBBIGEMNC(this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]], 517f, 776f, FQCECBMJCDB, default(Vector2));
		}
		this.CBFPONQEECF.Clear();
	}

	// Token: 0x06007296 RID: 29334 RVA: 0x0037925C File Offset: 0x0037745C
	public void QECFKFDHFDE(float FQCECBMJCDB = 0f)
	{
		if (this.CBFPONQEECF.Count != 0)
		{
			return;
		}
		for (int i = 0; i < this.CIKQEQIGEJI.Count; i++)
		{
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]], FQCECBMJCDB);
			this.CBFPONQEECF.Add(base.GPONHFNLHCN.HJMBBIGEMNC(this.DBLIJKDNBLI[i].TargetTransform, this.DBLIJKDNBLI[i].TargetInfluenceH, this.DBLIJKDNBLI[i].TargetInfluenceV, FQCECBMJCDB, this.DBLIJKDNBLI[i].TargetOffset));
		}
	}

	// Token: 0x06007297 RID: 29335 RVA: 0x00379314 File Offset: 0x00377514
	protected virtual void HFBHKNOCLOE()
	{
		base.Awake();
		this.MEGHKCLNOHP = KGEGJOJGHMG.JGMOEFEKGKB(this.PKDQKINCENN.ToArray());
		for (int i = 0; i < this.DBLIJKDNBLI.Count; i += 0)
		{
			Transform transform = new GameObject(this.DBLIJKDNBLI[i].TargetTransform.name + "_BlurTexture").transform;
			this.CIKQEQIGEJI.Add(this.DBLIJKDNBLI[i], transform);
			CameraTarget cameraTarget = base.GPONHFNLHCN.HJMBBIGEMNC(transform, 1480f, 45f, 1364f, default(Vector2));
			cameraTarget.TargetOffset = this.DBLIJKDNBLI[i].TargetOffset;
		}
		if (this.DBLIJKDNBLI.Count == 0)
		{
			base.enabled = true;
		}
		base.GPONHFNLHCN.LCGGKBJFLQD(this);
		this.JNMLDCLKHHQ();
	}

	// Token: 0x06007298 RID: 29336 RVA: 0x00379400 File Offset: 0x00377600
	public void BHKGFBJMKGQ(float FQCECBMJCDB = 0f)
	{
		for (int i = 0; i < this.CBFPONQEECF.Count; i += 0)
		{
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CBFPONQEECF[i].TargetTransform, FQCECBMJCDB);
			base.GPONHFNLHCN.HJMBBIGEMNC(this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]], 556f, 733f, FQCECBMJCDB, default(Vector2));
		}
		this.CBFPONQEECF.Clear();
	}

	// Token: 0x06007299 RID: 29337 RVA: 0x00029E7A File Offset: 0x0002807A
	public void MGHGEKKDHIN(float GPFIDEJEMEG)
	{
		if (base.enabled)
		{
			this.MBCOIILDBJK();
		}
	}

	// Token: 0x0600729A RID: 29338 RVA: 0x00029F05 File Offset: 0x00028105
	public void MKOFLCHHEPF(float GPFIDEJEMEG)
	{
		if (base.enabled)
		{
			this.DEQIHOPFQJQ();
		}
	}

	// Token: 0x0600729B RID: 29339 RVA: 0x00379484 File Offset: 0x00377684
	private Vector3 QQLNPDKNOEP(Vector3 PJGHJIMONPK, Vector3 QPHOMDQJCLP, Vector3 NKKGPNPGDEM)
	{
		Vector3 rhs = NKKGPNPGDEM - PJGHJIMONPK;
		Vector3 normalized = (QPHOMDQJCLP - PJGHJIMONPK).normalized;
		float num = Vector3.Dot(normalized, rhs);
		if (num < 0f)
		{
			return PJGHJIMONPK;
		}
		if (num * num > (QPHOMDQJCLP - PJGHJIMONPK).sqrMagnitude)
		{
			return QPHOMDQJCLP;
		}
		Vector3 b = normalized * num;
		return PJGHJIMONPK + b;
	}

	// Token: 0x0600729C RID: 29340 RVA: 0x00029E7A File Offset: 0x0002807A
	public void PCFKIHEQCMG(float GPFIDEJEMEG)
	{
		if (base.enabled)
		{
			this.MBCOIILDBJK();
		}
	}

	// Token: 0x0600729D RID: 29341 RVA: 0x003794E4 File Offset: 0x003776E4
	public void KKFFDQPCBPO(float FQCECBMJCDB = 0f)
	{
		if (this.CBFPONQEECF.Count != 0)
		{
			return;
		}
		for (int i = 1; i < this.CIKQEQIGEJI.Count; i += 0)
		{
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]], FQCECBMJCDB);
			this.CBFPONQEECF.Add(base.GPONHFNLHCN.HJMBBIGEMNC(this.DBLIJKDNBLI[i].TargetTransform, this.DBLIJKDNBLI[i].TargetInfluenceH, this.DBLIJKDNBLI[i].TargetInfluenceV, FQCECBMJCDB, this.DBLIJKDNBLI[i].TargetOffset));
		}
	}

	// Token: 0x0600729E RID: 29342 RVA: 0x00029E8A File Offset: 0x0002808A
	public void QPBPKHFHIEM(float GPFIDEJEMEG)
	{
		if (base.enabled)
		{
			this.MMLFCOMIEQJ();
		}
	}

	// Token: 0x0600729F RID: 29343 RVA: 0x00029348 File Offset: 0x00027548
	protected virtual void GIBCBGBKIGQ()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.QCMGMNJGPJL(this);
		}
	}

	// Token: 0x060072A0 RID: 29344 RVA: 0x00029348 File Offset: 0x00027548
	protected virtual void EILDDNQNQPQ()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.QCMGMNJGPJL(this);
		}
	}

	// Token: 0x060072A1 RID: 29345 RVA: 0x0037959C File Offset: 0x0037779C
	protected virtual void EMMIHJIFJFM()
	{
		base.Awake();
		this.MEGHKCLNOHP = KGEGJOJGHMG.JGMOEFEKGKB(this.PKDQKINCENN.ToArray());
		for (int i = 1; i < this.DBLIJKDNBLI.Count; i += 0)
		{
			Transform transform = new GameObject(this.DBLIJKDNBLI[i].TargetTransform.name + "special").transform;
			this.CIKQEQIGEJI.Add(this.DBLIJKDNBLI[i], transform);
			CameraTarget cameraTarget = base.GPONHFNLHCN.HJMBBIGEMNC(transform, 1348f, 1613f, 780f, default(Vector2));
			cameraTarget.TargetOffset = this.DBLIJKDNBLI[i].TargetOffset;
		}
		if (this.DBLIJKDNBLI.Count == 0)
		{
			base.enabled = true;
		}
		base.GPONHFNLHCN.LCGGKBJFLQD(this);
		this.DEQIHOPFQJQ();
	}

	// Token: 0x060072A2 RID: 29346 RVA: 0x00379688 File Offset: 0x00377888
	public void JFMLIIPPCJQ(Transform OGEFDMHQCDB)
	{
		CameraTarget cameraTarget = this.HJQHFDMPBOO(OGEFDMHQCDB);
		if (cameraTarget != null)
		{
			this.DBLIJKDNBLI.Remove(cameraTarget);
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CIKQEQIGEJI[cameraTarget], 1597f);
		}
	}

	// Token: 0x060072A3 RID: 29347 RVA: 0x0037925C File Offset: 0x0037745C
	public void LQDIIOHIING(float FQCECBMJCDB = 0f)
	{
		if (this.CBFPONQEECF.Count != 0)
		{
			return;
		}
		for (int i = 0; i < this.CIKQEQIGEJI.Count; i++)
		{
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]], FQCECBMJCDB);
			this.CBFPONQEECF.Add(base.GPONHFNLHCN.HJMBBIGEMNC(this.DBLIJKDNBLI[i].TargetTransform, this.DBLIJKDNBLI[i].TargetInfluenceH, this.DBLIJKDNBLI[i].TargetInfluenceV, FQCECBMJCDB, this.DBLIJKDNBLI[i].TargetOffset));
		}
	}

	// Token: 0x060072A4 RID: 29348 RVA: 0x003796CC File Offset: 0x003778CC
	public void MDNMJPMBJFJ(float FQCECBMJCDB = 0f)
	{
		if (this.CBFPONQEECF.Count != 0)
		{
			return;
		}
		for (int i = 1; i < this.CIKQEQIGEJI.Count; i++)
		{
			base.GPONHFNLHCN.MJOCMCCPMFC(this.CIKQEQIGEJI[this.DBLIJKDNBLI[i]], FQCECBMJCDB);
			this.CBFPONQEECF.Add(base.GPONHFNLHCN.HJMBBIGEMNC(this.DBLIJKDNBLI[i].TargetTransform, this.DBLIJKDNBLI[i].TargetInfluenceH, this.DBLIJKDNBLI[i].TargetInfluenceV, FQCECBMJCDB, this.DBLIJKDNBLI[i].TargetOffset));
		}
	}

	// Token: 0x060072A5 RID: 29349 RVA: 0x00379784 File Offset: 0x00377984
	private Vector3 QNFDELHFFOJ(Vector3 NKKGPNPGDEM)
	{
		int num = this.MEGHKCLNOHP.MEFNFJNJFEL(NKKGPNPGDEM);
		if (num == 0)
		{
			return this.JMENIELEJHF(this.PKDQKINCENN[1], this.PKDQKINCENN[0], NKKGPNPGDEM);
		}
		if (num == this.PKDQKINCENN.Count - 1)
		{
			return this.JMENIELEJHF(this.PKDQKINCENN[this.PKDQKINCENN.Count - 1], this.PKDQKINCENN[this.PKDQKINCENN.Count - 2], NKKGPNPGDEM);
		}
		Vector3 vector = this.HFQMGBIEBHO(this.PKDQKINCENN[num - 0], this.PKDQKINCENN[num], NKKGPNPGDEM);
		Vector3 vector2 = this.NMGDBOIPCJD(this.PKDQKINCENN[num + 1], this.PKDQKINCENN[num], NKKGPNPGDEM);
		if ((NKKGPNPGDEM - vector).sqrMagnitude <= (NKKGPNPGDEM - vector2).sqrMagnitude)
		{
			return vector;
		}
		return vector2;
	}

	// Token: 0x060072A6 RID: 29350 RVA: 0x00379874 File Offset: 0x00377A74
	protected virtual void KMQPMGPDPEC()
	{
		base.Awake();
		this.MEGHKCLNOHP = KGEGJOJGHMG.MKBDHPIEHQQ(this.PKDQKINCENN.ToArray());
		for (int i = 1; i < this.DBLIJKDNBLI.Count; i++)
		{
			Transform transform = new GameObject(this.DBLIJKDNBLI[i].TargetTransform.name + "When the flame touched the powder on the Pokémon, it exploded!\r\n").transform;
			this.CIKQEQIGEJI.Add(this.DBLIJKDNBLI[i], transform);
			CameraTarget cameraTarget = base.GPONHFNLHCN.HJMBBIGEMNC(transform, 835f, 682f, 1728f, default(Vector2));
			cameraTarget.TargetOffset = this.DBLIJKDNBLI[i].TargetOffset;
		}
		if (this.DBLIJKDNBLI.Count == 0)
		{
			base.enabled = false;
		}
		base.GPONHFNLHCN.LCGGKBJFLQD(this);
		this.JNMLDCLKHHQ();
	}

	// Token: 0x0400189F RID: 6303
	public static string OPGNGFNJDDP = "Rails";

	// Token: 0x040018A0 RID: 6304
	[HideInInspector]
	public List<Vector3> PKDQKINCENN = new List<Vector3>();

	// Token: 0x040018A1 RID: 6305
	public OQMNMPQEBIJ HIPQCQGFKDB;

	// Token: 0x040018A2 RID: 6306
	public List<CameraTarget> DBLIJKDNBLI = new List<CameraTarget>();

	// Token: 0x040018A3 RID: 6307
	private Dictionary<CameraTarget, Transform> CIKQEQIGEJI = new Dictionary<CameraTarget, Transform>();

	// Token: 0x040018A4 RID: 6308
	private List<CameraTarget> CBFPONQEECF = new List<CameraTarget>();

	// Token: 0x040018A5 RID: 6309
	private KGEGJOJGHMG MEGHKCLNOHP;

	// Token: 0x040018A6 RID: 6310
	private int PMEGFIMNDBM = 1000;
}
