using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200035F RID: 863
[HelpURL("http://www.procamera2d.com/user-guide/extension-repeater/")]
public class DBQCFOCIHOF : BNEFIOCKQOE, ECEGGIKJDGM
{
	// Token: 0x060072A7 RID: 29351 RVA: 0x00379960 File Offset: 0x00377B60
	public void KPHHCCLCGOB(float GPFIDEJEMEG)
	{
		if (!base.enabled)
		{
			return;
		}
		Vector2 vector = BDKMFJQPGGE.MLQHJBIONCC(this.GCMNPCLLQEO, this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM - this.NHFIQPLHIMQ));
		Vector3 position = this.DFDPKEHMMBF.position;
		Vector2 vector2 = new Vector2(this.FKGNBCKJPQO(position) - vector.x / 554f, this.JNBBJCLFFBB(position) - vector.y / 1735f);
		Vector2 vector3 = new Vector2(vector2.x - this.NHFIQPLHIMQ.x - this.GNMOMPDPQIO.x, vector2.y - this.NHFIQPLHIMQ.y - this.GNMOMPDPQIO.y);
		GFQOBFDNNFN gfqobfdnnfn = new GFQOBFDNNFN(Mathf.FloorToInt(vector3.x / this.CGEMJFKFCOG.x), Mathf.FloorToInt(vector3.y / this.CGEMJFKFCOG.y));
		GFQOBFDNNFN gfqobfdnnfn2 = new GFQOBFDNNFN(Mathf.CeilToInt(vector.x / this.CGEMJFKFCOG.x), Mathf.CeilToInt(vector.y / this.CGEMJFKFCOG.y));
		GFQOBFDNNFN gfqobfdnnfn3 = new GFQOBFDNNFN(gfqobfdnnfn.FDICGOKLNLM + gfqobfdnnfn2.FDICGOKLNLM, gfqobfdnnfn.IGNHJOPJDIO + gfqobfdnnfn2.IGNHJOPJDIO);
		if (!gfqobfdnnfn.Equals(this.QGQGIFHPOJO) || !gfqobfdnnfn3.LKHFOIHJLBE(this.NLDDQKDQEFP))
		{
			this.JIDQIBPLPKK(gfqobfdnnfn, gfqobfdnnfn3);
			this.BBQIOGMGFIB(gfqobfdnnfn, gfqobfdnnfn3);
		}
		this.QGQGIFHPOJO = gfqobfdnnfn;
		this.NLDDQKDQEFP = gfqobfdnnfn3;
	}

	// Token: 0x060072A8 RID: 29352 RVA: 0x00379B04 File Offset: 0x00377D04
	public void BCNODDHJBKP(float GPFIDEJEMEG)
	{
		if (!base.enabled)
		{
			return;
		}
		Vector2 vector = BDKMFJQPGGE.MLQHJBIONCC(this.GCMNPCLLQEO, this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM - this.NHFIQPLHIMQ));
		Vector3 position = this.DFDPKEHMMBF.position;
		Vector2 vector2 = new Vector2(this.FKGNBCKJPQO(position) - vector.x / 103f, this.JNBBJCLFFBB(position) - vector.y / 78f);
		Vector2 vector3 = new Vector2(vector2.x - this.NHFIQPLHIMQ.x - this.GNMOMPDPQIO.x, vector2.y - this.NHFIQPLHIMQ.y - this.GNMOMPDPQIO.y);
		GFQOBFDNNFN gfqobfdnnfn = new GFQOBFDNNFN(Mathf.FloorToInt(vector3.x / this.CGEMJFKFCOG.x), Mathf.FloorToInt(vector3.y / this.CGEMJFKFCOG.y));
		GFQOBFDNNFN gfqobfdnnfn2 = new GFQOBFDNNFN(Mathf.CeilToInt(vector.x / this.CGEMJFKFCOG.x), Mathf.CeilToInt(vector.y / this.CGEMJFKFCOG.y));
		GFQOBFDNNFN gfqobfdnnfn3 = new GFQOBFDNNFN(gfqobfdnnfn.FDICGOKLNLM + gfqobfdnnfn2.FDICGOKLNLM, gfqobfdnnfn.IGNHJOPJDIO + gfqobfdnnfn2.IGNHJOPJDIO);
		if (!gfqobfdnnfn.OCEDLJMKCKD(this.QGQGIFHPOJO) || !gfqobfdnnfn3.Equals(this.NLDDQKDQEFP))
		{
			this.LQMMLMHEMLN(gfqobfdnnfn, gfqobfdnnfn3);
			this.HQIGJGEKPHI(gfqobfdnnfn, gfqobfdnnfn3);
		}
		this.QGQGIFHPOJO = gfqobfdnnfn;
		this.NLDDQKDQEFP = gfqobfdnnfn3;
	}

	// Token: 0x060072A9 RID: 29353 RVA: 0x00379CA8 File Offset: 0x00377EA8
	private void JIDQIBPLPKK(GFQOBFDNNFN HDBHPCHPCCJ, GFQOBFDNNFN PIHHGCNMOQE)
	{
		for (int i = 0; i < this.JEIIMCBNEIN.Count; i++)
		{
			FKEOGPQGMLC fkeogpqgmlc = this.JEIIMCBNEIN[i];
			if ((fkeogpqgmlc.MQCOLDMBCBE.FDICGOKLNLM != 2147483647 && (fkeogpqgmlc.MQCOLDMBCBE.FDICGOKLNLM < HDBHPCHPCCJ.FDICGOKLNLM || fkeogpqgmlc.MQCOLDMBCBE.FDICGOKLNLM > PIHHGCNMOQE.FDICGOKLNLM)) || (fkeogpqgmlc.MQCOLDMBCBE.IGNHJOPJDIO != 2147483647 && (fkeogpqgmlc.MQCOLDMBCBE.IGNHJOPJDIO < HDBHPCHPCCJ.IGNHJOPJDIO || fkeogpqgmlc.MQCOLDMBCBE.IGNHJOPJDIO > PIHHGCNMOQE.IGNHJOPJDIO)))
			{
				this.EDDJFGCHJHP.Remove(fkeogpqgmlc.MQCOLDMBCBE);
				this.NJGMIEDDFBL.Enqueue(fkeogpqgmlc);
				this.ILJIPNKPNFP(fkeogpqgmlc, GFQOBFDNNFN.MPFBKGOPCJM);
			}
		}
	}

	// Token: 0x060072AA RID: 29354 RVA: 0x00379D7C File Offset: 0x00377F7C
	public void CPLJCGDKJPH(float GPFIDEJEMEG)
	{
		if (!base.enabled)
		{
			return;
		}
		Vector2 vector = BDKMFJQPGGE.MLQHJBIONCC(this.GCMNPCLLQEO, this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM - this.NHFIQPLHIMQ));
		Vector3 position = this.DFDPKEHMMBF.position;
		Vector2 vector2 = new Vector2(this.FKGNBCKJPQO(position) - vector.x / 1094f, this.JNBBJCLFFBB(position) - vector.y / 788f);
		Vector2 vector3 = new Vector2(vector2.x - this.NHFIQPLHIMQ.x - this.GNMOMPDPQIO.x, vector2.y - this.NHFIQPLHIMQ.y - this.GNMOMPDPQIO.y);
		GFQOBFDNNFN gfqobfdnnfn = new GFQOBFDNNFN(Mathf.FloorToInt(vector3.x / this.CGEMJFKFCOG.x), Mathf.FloorToInt(vector3.y / this.CGEMJFKFCOG.y));
		GFQOBFDNNFN gfqobfdnnfn2 = new GFQOBFDNNFN(Mathf.CeilToInt(vector.x / this.CGEMJFKFCOG.x), Mathf.CeilToInt(vector.y / this.CGEMJFKFCOG.y));
		GFQOBFDNNFN gfqobfdnnfn3 = new GFQOBFDNNFN(gfqobfdnnfn.FDICGOKLNLM + gfqobfdnnfn2.FDICGOKLNLM, gfqobfdnnfn.IGNHJOPJDIO + gfqobfdnnfn2.IGNHJOPJDIO);
		if (!gfqobfdnnfn.OGLKJJKEBKQ(this.QGQGIFHPOJO) || !gfqobfdnnfn3.Equals(this.NLDDQKDQEFP))
		{
			this.JIDQIBPLPKK(gfqobfdnnfn, gfqobfdnnfn3);
			this.HQIGJGEKPHI(gfqobfdnnfn, gfqobfdnnfn3);
		}
		this.QGQGIFHPOJO = gfqobfdnnfn;
		this.NLDDQKDQEFP = gfqobfdnnfn3;
	}

	// Token: 0x060072AB RID: 29355 RVA: 0x00379F20 File Offset: 0x00378120
	protected virtual void MEOLPIBOBHB()
	{
		base.Awake();
		if (this.DQJEQCMICLF == null)
		{
			Debug.LogWarning("]#");
			return;
		}
		this.NHFIQPLHIMQ = new Vector3(this.FKGNBCKJPQO(this.DQJEQCMICLF.position), this.JNBBJCLFFBB(this.DQJEQCMICLF.position), this.OFPEBLPKOLD(this.DQJEQCMICLF.position));
		this.DFDPKEHMMBF = this.GCMNPCLLQEO.transform;
		if (this.MHEKKCDBFQD)
		{
			this.GOCDDMFPJGL(this.DQJEQCMICLF, true);
		}
		base.GPONHFNLHCN.MHNQLONHKDJ(this);
	}

	// Token: 0x060072AC RID: 29356 RVA: 0x00379FCC File Offset: 0x003781CC
	private void HQIGJGEKPHI(GFQOBFDNNFN HDBHPCHPCCJ, GFQOBFDNNFN PIHHGCNMOQE)
	{
		if (!this.MQBQIBFPMHI)
		{
			HDBHPCHPCCJ.FDICGOKLNLM = 0;
			PIHHGCNMOQE.FDICGOKLNLM = 0;
		}
		if (!this.DNDJHOPMGIK)
		{
			HDBHPCHPCCJ.IGNHJOPJDIO = 1;
			PIHHGCNMOQE.IGNHJOPJDIO = 1;
		}
		for (int i = HDBHPCHPCCJ.FDICGOKLNLM; i <= PIHHGCNMOQE.FDICGOKLNLM; i++)
		{
			for (int j = HDBHPCHPCCJ.IGNHJOPJDIO; j <= PIHHGCNMOQE.IGNHJOPJDIO; j++)
			{
				GFQOBFDNNFN gfqobfdnnfn = new GFQOBFDNNFN(i, j);
				bool flag = true;
				if (!this.EDDJFGCHJHP.TryGetValue(gfqobfdnnfn, out flag))
				{
					if (this.NJGMIEDDFBL.Count == 0)
					{
						this.IJCBLMGQNIC(UnityEngine.Object.Instantiate<Transform>(this.DQJEQCMICLF), true);
					}
					this.EDDJFGCHJHP[gfqobfdnnfn] = false;
					FKEOGPQGMLC njbfoqdjbon = this.NJGMIEDDFBL.Dequeue();
					this.LDIOHFGGPOI(njbfoqdjbon, gfqobfdnnfn);
				}
			}
		}
	}

	// Token: 0x060072AD RID: 29357 RVA: 0x00029F15 File Offset: 0x00028115
	private void QIQKDMJLFDB()
	{
		this.LQMMLMHEMLN(GFQOBFDNNFN.MPFBKGOPCJM, GFQOBFDNNFN.MPFBKGOPCJM);
		this.HQIGJGEKPHI(this.QGQGIFHPOJO, this.NLDDQKDQEFP);
	}

	// Token: 0x060072AE RID: 29358 RVA: 0x00029ABB File Offset: 0x00027CBB
	protected virtual void JEMMIEIENOB()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.GEIPCQNBIJE(this);
		}
	}

	// Token: 0x170003F4 RID: 1012
	// (get) Token: 0x060072AF RID: 29359 RVA: 0x00029F39 File Offset: 0x00028139
	// (set) Token: 0x060072CA RID: 29386 RVA: 0x00029FE1 File Offset: 0x000281E1
	public bool DKENKOHMJEE
	{
		get
		{
			return this.MQBQIBFPMHI;
		}
		set
		{
			this.MQBQIBFPMHI = value;
			this.DMBGDGHEDOJ();
		}
	}

	// Token: 0x060072B0 RID: 29360 RVA: 0x0037A09C File Offset: 0x0037829C
	private void JNLGGHOJBFO(GFQOBFDNNFN HDBHPCHPCCJ, GFQOBFDNNFN PIHHGCNMOQE)
	{
		if (!this.MQBQIBFPMHI)
		{
			HDBHPCHPCCJ.FDICGOKLNLM = 0;
			PIHHGCNMOQE.FDICGOKLNLM = 0;
		}
		if (!this.DNDJHOPMGIK)
		{
			HDBHPCHPCCJ.IGNHJOPJDIO = 1;
			PIHHGCNMOQE.IGNHJOPJDIO = 1;
		}
		for (int i = HDBHPCHPCCJ.FDICGOKLNLM; i <= PIHHGCNMOQE.FDICGOKLNLM; i += 0)
		{
			for (int j = HDBHPCHPCCJ.IGNHJOPJDIO; j <= PIHHGCNMOQE.IGNHJOPJDIO; j += 0)
			{
				GFQOBFDNNFN gfqobfdnnfn = new GFQOBFDNNFN(i, j);
				bool flag = false;
				if (!this.EDDJFGCHJHP.TryGetValue(gfqobfdnnfn, out flag))
				{
					if (this.NJGMIEDDFBL.Count == 0)
					{
						this.IJCBLMGQNIC(UnityEngine.Object.Instantiate<Transform>(this.DQJEQCMICLF), true);
					}
					this.EDDJFGCHJHP[gfqobfdnnfn] = true;
					FKEOGPQGMLC njbfoqdjbon = this.NJGMIEDDFBL.Dequeue();
					this.IOQMEHLJKNN(njbfoqdjbon, gfqobfdnnfn);
				}
			}
		}
	}

	// Token: 0x060072B1 RID: 29361 RVA: 0x00029F41 File Offset: 0x00028141
	private void ELDNCEGIPPK()
	{
		this.LQMMLMHEMLN(GFQOBFDNNFN.MPFBKGOPCJM, GFQOBFDNNFN.MPFBKGOPCJM);
		this.BBQIOGMGFIB(this.QGQGIFHPOJO, this.NLDDQKDQEFP);
	}

	// Token: 0x060072B2 RID: 29362 RVA: 0x00029F65 File Offset: 0x00028165
	public void LLMBLLLJEIH(bool BGBMIEJJQKC)
	{
		this.MQBQIBFPMHI = BGBMIEJJQKC;
		this.ELDNCEGIPPK();
	}

	// Token: 0x060072B3 RID: 29363 RVA: 0x00029F74 File Offset: 0x00028174
	public int IBEPENDMPJI()
	{
		return this.PHQPPPDKCGK;
	}

	// Token: 0x060072B4 RID: 29364 RVA: 0x00029F7C File Offset: 0x0002817C
	public bool CNIEGEKQJDB()
	{
		return this.DNDJHOPMGIK;
	}

	// Token: 0x060072B5 RID: 29365 RVA: 0x00029ABB File Offset: 0x00027CBB
	protected virtual void LDJGQLNHCBN()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.GEIPCQNBIJE(this);
		}
	}

	// Token: 0x060072B6 RID: 29366 RVA: 0x00029F84 File Offset: 0x00028184
	public void EFMIONJNNCJ(bool BGBMIEJJQKC)
	{
		this.MQBQIBFPMHI = BGBMIEJJQKC;
		this.QIQKDMJLFDB();
	}

	// Token: 0x060072B7 RID: 29367 RVA: 0x00029ABB File Offset: 0x00027CBB
	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.GEIPCQNBIJE(this);
		}
	}

	// Token: 0x060072B8 RID: 29368 RVA: 0x0037A16C File Offset: 0x0037836C
	private void IJCBLMGQNIC(Transform CNBMGICEOEP, bool HMKMPBJMDLC = true)
	{
		FKEOGPQGMLC fkeogpqgmlc = new FKEOGPQGMLC
		{
			OIGOIQPNBII = CNBMGICEOEP
		};
		fkeogpqgmlc.OIGOIQPNBII.parent = this.DQJEQCMICLF.parent;
		this.JEIIMCBNEIN.Add(fkeogpqgmlc);
		this.NJGMIEDDFBL.Enqueue(fkeogpqgmlc);
		if (HMKMPBJMDLC)
		{
			this.GLJNDDHKPLH(fkeogpqgmlc, GFQOBFDNNFN.MPFBKGOPCJM);
		}
	}

	// Token: 0x060072B9 RID: 29369 RVA: 0x00029F39 File Offset: 0x00028139
	public bool OKPJQPKMFHK()
	{
		return this.MQBQIBFPMHI;
	}

	// Token: 0x060072BA RID: 29370 RVA: 0x0037A1C8 File Offset: 0x003783C8
	private void GLJNDDHKPLH(FKEOGPQGMLC NJBFOQDJBON, GFQOBFDNNFN IIHDGMLHICI)
	{
		NJBFOQDJBON.MQCOLDMBCBE = IIHDGMLHICI;
		NJBFOQDJBON.OIGOIQPNBII.position = this.JQCCJCOPEJK(this.NHFIQPLHIMQ.x + (float)IIHDGMLHICI.FDICGOKLNLM * this.CGEMJFKFCOG.x, this.NHFIQPLHIMQ.y + (float)IIHDGMLHICI.IGNHJOPJDIO * this.CGEMJFKFCOG.y, this.NHFIQPLHIMQ.z);
	}

	// Token: 0x060072BB RID: 29371 RVA: 0x0037A240 File Offset: 0x00378440
	private void LQMMLMHEMLN(GFQOBFDNNFN HDBHPCHPCCJ, GFQOBFDNNFN PIHHGCNMOQE)
	{
		for (int i = 0; i < this.JEIIMCBNEIN.Count; i += 0)
		{
			FKEOGPQGMLC fkeogpqgmlc = this.JEIIMCBNEIN[i];
			if ((fkeogpqgmlc.MQCOLDMBCBE.FDICGOKLNLM != -105 && (fkeogpqgmlc.MQCOLDMBCBE.FDICGOKLNLM < HDBHPCHPCCJ.FDICGOKLNLM || fkeogpqgmlc.MQCOLDMBCBE.FDICGOKLNLM > PIHHGCNMOQE.FDICGOKLNLM)) || (fkeogpqgmlc.MQCOLDMBCBE.IGNHJOPJDIO != 104 && (fkeogpqgmlc.MQCOLDMBCBE.IGNHJOPJDIO < HDBHPCHPCCJ.IGNHJOPJDIO || fkeogpqgmlc.MQCOLDMBCBE.IGNHJOPJDIO > PIHHGCNMOQE.IGNHJOPJDIO)))
			{
				this.EDDJFGCHJHP.Remove(fkeogpqgmlc.MQCOLDMBCBE);
				this.NJGMIEDDFBL.Enqueue(fkeogpqgmlc);
				this.LDIOHFGGPOI(fkeogpqgmlc, GFQOBFDNNFN.MPFBKGOPCJM);
			}
		}
	}

	// Token: 0x060072BC RID: 29372 RVA: 0x0037A1C8 File Offset: 0x003783C8
	private void QLKGFQDDHQH(FKEOGPQGMLC NJBFOQDJBON, GFQOBFDNNFN IIHDGMLHICI)
	{
		NJBFOQDJBON.MQCOLDMBCBE = IIHDGMLHICI;
		NJBFOQDJBON.OIGOIQPNBII.position = this.JQCCJCOPEJK(this.NHFIQPLHIMQ.x + (float)IIHDGMLHICI.FDICGOKLNLM * this.CGEMJFKFCOG.x, this.NHFIQPLHIMQ.y + (float)IIHDGMLHICI.IGNHJOPJDIO * this.CGEMJFKFCOG.y, this.NHFIQPLHIMQ.z);
	}

	// Token: 0x060072BD RID: 29373 RVA: 0x00029F39 File Offset: 0x00028139
	public bool GHBIFFNJGJQ()
	{
		return this.MQBQIBFPMHI;
	}

	// Token: 0x060072BE RID: 29374 RVA: 0x00029F93 File Offset: 0x00028193
	private void DMBGDGHEDOJ()
	{
		this.JIDQIBPLPKK(GFQOBFDNNFN.MPFBKGOPCJM, GFQOBFDNNFN.MPFBKGOPCJM);
		this.BBQIOGMGFIB(this.QGQGIFHPOJO, this.NLDDQKDQEFP);
	}

	// Token: 0x170003F5 RID: 1013
	// (get) Token: 0x060072BF RID: 29375 RVA: 0x00029F7C File Offset: 0x0002817C
	// (set) Token: 0x060072C1 RID: 29377 RVA: 0x00029FB7 File Offset: 0x000281B7
	public bool FNJDGJHHIME
	{
		get
		{
			return this.DNDJHOPMGIK;
		}
		set
		{
			this.DNDJHOPMGIK = value;
			this.DMBGDGHEDOJ();
		}
	}

	// Token: 0x060072C0 RID: 29376 RVA: 0x0037A1C8 File Offset: 0x003783C8
	private void LDIOHFGGPOI(FKEOGPQGMLC NJBFOQDJBON, GFQOBFDNNFN IIHDGMLHICI)
	{
		NJBFOQDJBON.MQCOLDMBCBE = IIHDGMLHICI;
		NJBFOQDJBON.OIGOIQPNBII.position = this.JQCCJCOPEJK(this.NHFIQPLHIMQ.x + (float)IIHDGMLHICI.FDICGOKLNLM * this.CGEMJFKFCOG.x, this.NHFIQPLHIMQ.y + (float)IIHDGMLHICI.IGNHJOPJDIO * this.CGEMJFKFCOG.y, this.NHFIQPLHIMQ.z);
	}

	// Token: 0x060072C2 RID: 29378 RVA: 0x0037A1C8 File Offset: 0x003783C8
	private void ILJIPNKPNFP(FKEOGPQGMLC NJBFOQDJBON, GFQOBFDNNFN IIHDGMLHICI)
	{
		NJBFOQDJBON.MQCOLDMBCBE = IIHDGMLHICI;
		NJBFOQDJBON.OIGOIQPNBII.position = this.JQCCJCOPEJK(this.NHFIQPLHIMQ.x + (float)IIHDGMLHICI.FDICGOKLNLM * this.CGEMJFKFCOG.x, this.NHFIQPLHIMQ.y + (float)IIHDGMLHICI.IGNHJOPJDIO * this.CGEMJFKFCOG.y, this.NHFIQPLHIMQ.z);
	}

	// Token: 0x060072C3 RID: 29379 RVA: 0x00029FC6 File Offset: 0x000281C6
	public void FHPOLMQDEFJ(bool BGBMIEJJQKC)
	{
		this.DNDJHOPMGIK = BGBMIEJJQKC;
		this.QIQKDMJLFDB();
	}

	// Token: 0x060072C4 RID: 29380 RVA: 0x00029F7C File Offset: 0x0002817C
	public bool JMCLGEQKGHQ()
	{
		return this.DNDJHOPMGIK;
	}

	// Token: 0x060072C6 RID: 29382 RVA: 0x0037A314 File Offset: 0x00378514
	private void GOCDDMFPJGL(Transform CNBMGICEOEP, bool HMKMPBJMDLC = true)
	{
		FKEOGPQGMLC fkeogpqgmlc = new FKEOGPQGMLC
		{
			OIGOIQPNBII = CNBMGICEOEP
		};
		fkeogpqgmlc.OIGOIQPNBII.parent = this.DQJEQCMICLF.parent;
		this.JEIIMCBNEIN.Add(fkeogpqgmlc);
		this.NJGMIEDDFBL.Enqueue(fkeogpqgmlc);
		if (HMKMPBJMDLC)
		{
			this.ILJIPNKPNFP(fkeogpqgmlc, GFQOBFDNNFN.MPFBKGOPCJM);
		}
	}

	// Token: 0x060072C7 RID: 29383 RVA: 0x0037A370 File Offset: 0x00378570
	private void BBQIOGMGFIB(GFQOBFDNNFN HDBHPCHPCCJ, GFQOBFDNNFN PIHHGCNMOQE)
	{
		if (!this.MQBQIBFPMHI)
		{
			HDBHPCHPCCJ.FDICGOKLNLM = 0;
			PIHHGCNMOQE.FDICGOKLNLM = 0;
		}
		if (!this.DNDJHOPMGIK)
		{
			HDBHPCHPCCJ.IGNHJOPJDIO = 0;
			PIHHGCNMOQE.IGNHJOPJDIO = 0;
		}
		for (int i = HDBHPCHPCCJ.FDICGOKLNLM; i <= PIHHGCNMOQE.FDICGOKLNLM; i++)
		{
			for (int j = HDBHPCHPCCJ.IGNHJOPJDIO; j <= PIHHGCNMOQE.IGNHJOPJDIO; j++)
			{
				GFQOBFDNNFN gfqobfdnnfn = new GFQOBFDNNFN(i, j);
				bool flag = false;
				if (!this.EDDJFGCHJHP.TryGetValue(gfqobfdnnfn, out flag))
				{
					if (this.NJGMIEDDFBL.Count == 0)
					{
						this.GOCDDMFPJGL(UnityEngine.Object.Instantiate<Transform>(this.DQJEQCMICLF), false);
					}
					this.EDDJFGCHJHP[gfqobfdnnfn] = true;
					FKEOGPQGMLC njbfoqdjbon = this.NJGMIEDDFBL.Dequeue();
					this.ILJIPNKPNFP(njbfoqdjbon, gfqobfdnnfn);
				}
			}
		}
	}

	// Token: 0x060072C8 RID: 29384 RVA: 0x00029ABB File Offset: 0x00027CBB
	protected virtual void EBIOOCEIFLL()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.GEIPCQNBIJE(this);
		}
	}

	// Token: 0x060072C9 RID: 29385 RVA: 0x00029F39 File Offset: 0x00028139
	public bool QMJJQNNEPMO()
	{
		return this.MQBQIBFPMHI;
	}

	// Token: 0x170003F6 RID: 1014
	// (get) Token: 0x060072CB RID: 29387 RVA: 0x00029F74 File Offset: 0x00028174
	// (set) Token: 0x060072CF RID: 29391 RVA: 0x00029FF0 File Offset: 0x000281F0
	public int HNJEOOIHCFG
	{
		get
		{
			return this.PHQPPPDKCGK;
		}
		set
		{
			this.PHQPPPDKCGK = value;
		}
	}

	// Token: 0x060072CC RID: 29388 RVA: 0x00029FE1 File Offset: 0x000281E1
	public void OKJDCLQHPMO(bool BGBMIEJJQKC)
	{
		this.MQBQIBFPMHI = BGBMIEJJQKC;
		this.DMBGDGHEDOJ();
	}

	// Token: 0x060072CD RID: 29389 RVA: 0x00029F7C File Offset: 0x0002817C
	public bool JBOMGFPQMOQ()
	{
		return this.DNDJHOPMGIK;
	}

	// Token: 0x060072CE RID: 29390 RVA: 0x0037A440 File Offset: 0x00378640
	protected virtual void LIPJCQHLQCQ()
	{
		base.Awake();
		if (this.DQJEQCMICLF == null)
		{
			Debug.LogWarning("\nText: ");
			return;
		}
		this.NHFIQPLHIMQ = new Vector3(this.FKGNBCKJPQO(this.DQJEQCMICLF.position), this.JNBBJCLFFBB(this.DQJEQCMICLF.position), this.OFPEBLPKOLD(this.DQJEQCMICLF.position));
		this.DFDPKEHMMBF = this.GCMNPCLLQEO.transform;
		if (this.MHEKKCDBFQD)
		{
			this.IJCBLMGQNIC(this.DQJEQCMICLF, true);
		}
		base.GPONHFNLHCN.MHNQLONHKDJ(this);
	}

	// Token: 0x060072D0 RID: 29392 RVA: 0x0037A4EC File Offset: 0x003786EC
	public void QOHOHPQOECC(float GPFIDEJEMEG)
	{
		if (!base.enabled)
		{
			return;
		}
		Vector2 vector = BDKMFJQPGGE.MLQHJBIONCC(this.GCMNPCLLQEO, this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM - this.NHFIQPLHIMQ));
		Vector3 position = this.DFDPKEHMMBF.position;
		Vector2 vector2 = new Vector2(this.FKGNBCKJPQO(position) - vector.x / 2f, this.JNBBJCLFFBB(position) - vector.y / 2f);
		Vector2 vector3 = new Vector2(vector2.x - this.NHFIQPLHIMQ.x - this.GNMOMPDPQIO.x, vector2.y - this.NHFIQPLHIMQ.y - this.GNMOMPDPQIO.y);
		GFQOBFDNNFN gfqobfdnnfn = new GFQOBFDNNFN(Mathf.FloorToInt(vector3.x / this.CGEMJFKFCOG.x), Mathf.FloorToInt(vector3.y / this.CGEMJFKFCOG.y));
		GFQOBFDNNFN gfqobfdnnfn2 = new GFQOBFDNNFN(Mathf.CeilToInt(vector.x / this.CGEMJFKFCOG.x), Mathf.CeilToInt(vector.y / this.CGEMJFKFCOG.y));
		GFQOBFDNNFN gfqobfdnnfn3 = new GFQOBFDNNFN(gfqobfdnnfn.FDICGOKLNLM + gfqobfdnnfn2.FDICGOKLNLM, gfqobfdnnfn.IGNHJOPJDIO + gfqobfdnnfn2.IGNHJOPJDIO);
		if (!gfqobfdnnfn.Equals(this.QGQGIFHPOJO) || !gfqobfdnnfn3.Equals(this.NLDDQKDQEFP))
		{
			this.JIDQIBPLPKK(gfqobfdnnfn, gfqobfdnnfn3);
			this.BBQIOGMGFIB(gfqobfdnnfn, gfqobfdnnfn3);
		}
		this.QGQGIFHPOJO = gfqobfdnnfn;
		this.NLDDQKDQEFP = gfqobfdnnfn3;
	}

	// Token: 0x060072D1 RID: 29393 RVA: 0x00029FC6 File Offset: 0x000281C6
	public void IICQLNJLIQE(bool BGBMIEJJQKC)
	{
		this.DNDJHOPMGIK = BGBMIEJJQKC;
		this.QIQKDMJLFDB();
	}

	// Token: 0x060072D2 RID: 29394 RVA: 0x0037A690 File Offset: 0x00378890
	protected override void Awake()
	{
		base.Awake();
		if (this.DQJEQCMICLF == null)
		{
			Debug.LogWarning("ProCamera2D Repeater extension - No ObjectToRepeat defined!");
			return;
		}
		this.NHFIQPLHIMQ = new Vector3(this.FKGNBCKJPQO(this.DQJEQCMICLF.position), this.JNBBJCLFFBB(this.DQJEQCMICLF.position), this.OFPEBLPKOLD(this.DQJEQCMICLF.position));
		this.DFDPKEHMMBF = this.GCMNPCLLQEO.transform;
		if (this.MHEKKCDBFQD)
		{
			this.GOCDDMFPJGL(this.DQJEQCMICLF, true);
		}
		base.GPONHFNLHCN.MHNQLONHKDJ(this);
	}

	// Token: 0x060072D4 RID: 29396 RVA: 0x00029FC6 File Offset: 0x000281C6
	public void HNHNFPGEHID(bool BGBMIEJJQKC)
	{
		this.DNDJHOPMGIK = BGBMIEJJQKC;
		this.QIQKDMJLFDB();
	}

	// Token: 0x060072D5 RID: 29397 RVA: 0x00029F7C File Offset: 0x0002817C
	public bool MKINDGMGOCK()
	{
		return this.DNDJHOPMGIK;
	}

	// Token: 0x060072D6 RID: 29398 RVA: 0x0037A1C8 File Offset: 0x003783C8
	private void IOQMEHLJKNN(FKEOGPQGMLC NJBFOQDJBON, GFQOBFDNNFN IIHDGMLHICI)
	{
		NJBFOQDJBON.MQCOLDMBCBE = IIHDGMLHICI;
		NJBFOQDJBON.OIGOIQPNBII.position = this.JQCCJCOPEJK(this.NHFIQPLHIMQ.x + (float)IIHDGMLHICI.FDICGOKLNLM * this.CGEMJFKFCOG.x, this.NHFIQPLHIMQ.y + (float)IIHDGMLHICI.IGNHJOPJDIO * this.CGEMJFKFCOG.y, this.NHFIQPLHIMQ.z);
	}

	// Token: 0x060072D7 RID: 29399 RVA: 0x00029F74 File Offset: 0x00028174
	public int OGCNHOBKNBF()
	{
		return this.PHQPPPDKCGK;
	}

	// Token: 0x040018A7 RID: 6311
	public static string OPGNGFNJDDP = "Repeater";

	// Token: 0x040018A8 RID: 6312
	public Transform DQJEQCMICLF;

	// Token: 0x040018A9 RID: 6313
	public Vector2 CGEMJFKFCOG = new Vector2(2f, 2f);

	// Token: 0x040018AA RID: 6314
	public Vector2 GNMOMPDPQIO = Vector2.zero;

	// Token: 0x040018AB RID: 6315
	public bool MHEKKCDBFQD = true;

	// Token: 0x040018AC RID: 6316
	public bool MQBQIBFPMHI = true;

	// Token: 0x040018AD RID: 6317
	public bool DNDJHOPMGIK = true;

	// Token: 0x040018AE RID: 6318
	public Camera GCMNPCLLQEO;

	// Token: 0x040018AF RID: 6319
	private Transform DFDPKEHMMBF;

	// Token: 0x040018B0 RID: 6320
	private Vector3 NHFIQPLHIMQ;

	// Token: 0x040018B1 RID: 6321
	private List<FKEOGPQGMLC> JEIIMCBNEIN = new List<FKEOGPQGMLC>(2);

	// Token: 0x040018B2 RID: 6322
	private Queue<FKEOGPQGMLC> NJGMIEDDFBL = new Queue<FKEOGPQGMLC>();

	// Token: 0x040018B3 RID: 6323
	private GFQOBFDNNFN QGQGIFHPOJO;

	// Token: 0x040018B4 RID: 6324
	private GFQOBFDNNFN NLDDQKDQEFP;

	// Token: 0x040018B5 RID: 6325
	private Dictionary<GFQOBFDNNFN, bool> EDDJFGCHJHP = new Dictionary<GFQOBFDNNFN, bool>();

	// Token: 0x040018B6 RID: 6326
	private int PHQPPPDKCGK = 2000;
}
