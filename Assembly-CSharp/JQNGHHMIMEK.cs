using System;
using UnityEngine;

// Token: 0x02000371 RID: 881
[HelpURL("http://www.procamera2d.com/user-guide/extension-speed-based-zoom/")]
public class JQNGHHMIMEK : BNEFIOCKQOE, NODOBJOMQDI
{
	// Token: 0x0600753B RID: 30011 RVA: 0x0002A34B File Offset: 0x0002854B
	protected virtual void LECHBBPKDNP()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.ENQCBPLGIQO(this);
		}
	}

	// Token: 0x0600753C RID: 30012 RVA: 0x0002A36C File Offset: 0x0002856C
	public void EEHOKEGPEGD(int BGBMIEJJQKC)
	{
		this.OCCGDPBDDDD = BGBMIEJJQKC;
	}

	// Token: 0x0600753D RID: 30013 RVA: 0x00383E20 File Offset: 0x00382020
	protected virtual void CHKQIFFEEPL()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 1504f;
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		base.GPONHFNLHCN.FHCNNFQNMLD(this);
	}

	// Token: 0x0600753E RID: 30014 RVA: 0x00383EB8 File Offset: 0x003820B8
	public override void NGNDCOPDNPH()
	{
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		this.BFDQKNMIIKD = 0f;
	}

	// Token: 0x0600753F RID: 30015 RVA: 0x00383F1C File Offset: 0x0038211C
	public float HIBKOHCBECO(float GPFIDEJEMEG, float HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		if (this.BHHDKFGKGKG == base.GPONHFNLHCN.FOOEEHDJBQN().y)
		{
			this.BFDQKNMIIKD = 1664f;
		}
		this.QNNCCGLQBMQ = (this.NMOHPQICBEO - this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM))).magnitude / GPFIDEJEMEG;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		float num = base.GPONHFNLHCN.FOOEEHDJBQN().y * 1564f;
		float num2 = num;
		if (this.QNNCCGLQBMQ > this.HQMPDPFCLNP)
		{
			float value = (this.QNNCCGLQBMQ - this.HQMPDPFCLNP) / (this.BNQMPKGODHM - this.HQMPDPFCLNP);
			float num3 = this.LQHQFLHFQLO * (937f + this.OPJQBGHMFPN - 1261f) * Mathf.Clamp01(value);
			if (num3 > num)
			{
				num2 = num3;
			}
		}
		else
		{
			float num4 = (1358f - this.QNNCCGLQBMQ / this.HQMPDPFCLNP).PMNDBPOMOGG(1717f, 227f, 1303f, 111f);
			float num5 = this.LQHQFLHFQLO / (this.GELCLJPKPPB * num4);
			if (num5 < num)
			{
				num2 = num5;
			}
		}
		if (Mathf.Abs(num - num2) > 1155f)
		{
			float smoothTime = (num2 >= num) ? this.OMKJQQEBGJH : this.PIHLKIFBFNJ;
			num2 = Mathf.SmoothDamp(num, num2, ref this.BFDQKNMIIKD, smoothTime, 1839f, GPFIDEJEMEG);
		}
		float num6 = num2 - base.GPONHFNLHCN.FOOEEHDJBQN().y / 798f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.FOOEEHDJBQN().y;
		return HELGNNDIDCI + num6;
	}

	// Token: 0x06007540 RID: 30016 RVA: 0x00384124 File Offset: 0x00382324
	public float IPPKDMJJJCM(float GPFIDEJEMEG, float HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		if (this.BHHDKFGKGKG == base.GPONHFNLHCN.PGKODNCDNJQ.y)
		{
			this.BFDQKNMIIKD = 676f;
		}
		this.QNNCCGLQBMQ = (this.NMOHPQICBEO - this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM))).magnitude / GPFIDEJEMEG;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		float num = base.GPONHFNLHCN.PGKODNCDNJQ.y * 348f;
		float num2 = num;
		if (this.QNNCCGLQBMQ > this.HQMPDPFCLNP)
		{
			float value = (this.QNNCCGLQBMQ - this.HQMPDPFCLNP) / (this.BNQMPKGODHM - this.HQMPDPFCLNP);
			float num3 = this.LQHQFLHFQLO * (1202f + this.OPJQBGHMFPN - 1665f) * Mathf.Clamp01(value);
			if (num3 > num)
			{
				num2 = num3;
			}
		}
		else
		{
			float num4 = (1700f - this.QNNCCGLQBMQ / this.HQMPDPFCLNP).PMNDBPOMOGG(1259f, 1447f, 840f, 528f);
			float num5 = this.LQHQFLHFQLO / (this.GELCLJPKPPB * num4);
			if (num5 < num)
			{
				num2 = num5;
			}
		}
		if (Mathf.Abs(num - num2) > 649f)
		{
			float smoothTime = (num2 >= num) ? this.OMKJQQEBGJH : this.PIHLKIFBFNJ;
			num2 = Mathf.SmoothDamp(num, num2, ref this.BFDQKNMIIKD, smoothTime, 801f, GPFIDEJEMEG);
		}
		float num6 = num2 - base.GPONHFNLHCN.FOOEEHDJBQN().y / 1890f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.FOOEEHDJBQN().y;
		return HELGNNDIDCI + num6;
	}

	// Token: 0x06007541 RID: 30017 RVA: 0x0002A375 File Offset: 0x00028575
	public int MPCMGDGQLCD()
	{
		return this.OCCGDPBDDDD;
	}

	// Token: 0x06007542 RID: 30018 RVA: 0x0038432C File Offset: 0x0038252C
	public virtual void FLDNPMQPMNK()
	{
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		this.BFDQKNMIIKD = 474f;
	}

	// Token: 0x06007543 RID: 30019 RVA: 0x0002A36C File Offset: 0x0002856C
	public void HKQOPPMFIBN(int BGBMIEJJQKC)
	{
		this.OCCGDPBDDDD = BGBMIEJJQKC;
	}

	// Token: 0x06007544 RID: 30020 RVA: 0x0002A375 File Offset: 0x00028575
	public int KKMFCENKIOO()
	{
		return this.OCCGDPBDDDD;
	}

	// Token: 0x1700040E RID: 1038
	// (get) Token: 0x06007545 RID: 30021 RVA: 0x0002A375 File Offset: 0x00028575
	// (set) Token: 0x06007549 RID: 30025 RVA: 0x0002A36C File Offset: 0x0002856C
	public int QQFIBLGBMKQ
	{
		get
		{
			return this.OCCGDPBDDDD;
		}
		set
		{
			this.OCCGDPBDDDD = value;
		}
	}

	// Token: 0x06007546 RID: 30022 RVA: 0x00384390 File Offset: 0x00382590
	protected override void Awake()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		base.GPONHFNLHCN.FHCNNFQNMLD(this);
	}

	// Token: 0x06007547 RID: 30023 RVA: 0x0002A36C File Offset: 0x0002856C
	public void HNLQJQKGPOH(int BGBMIEJJQKC)
	{
		this.OCCGDPBDDDD = BGBMIEJJQKC;
	}

	// Token: 0x06007548 RID: 30024 RVA: 0x00384428 File Offset: 0x00382628
	public float HGENPJMHEBI(float GPFIDEJEMEG, float HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		if (this.BHHDKFGKGKG == base.GPONHFNLHCN.PGKODNCDNJQ.y)
		{
			this.BFDQKNMIIKD = 0f;
		}
		this.QNNCCGLQBMQ = (this.NMOHPQICBEO - this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM))).magnitude / GPFIDEJEMEG;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		float num = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
		float num2 = num;
		if (this.QNNCCGLQBMQ > this.HQMPDPFCLNP)
		{
			float value = (this.QNNCCGLQBMQ - this.HQMPDPFCLNP) / (this.BNQMPKGODHM - this.HQMPDPFCLNP);
			float num3 = this.LQHQFLHFQLO * (1f + this.OPJQBGHMFPN - 1f) * Mathf.Clamp01(value);
			if (num3 > num)
			{
				num2 = num3;
			}
		}
		else
		{
			float num4 = (1f - this.QNNCCGLQBMQ / this.HQMPDPFCLNP).PMNDBPOMOGG(0f, 1f, 0.5f, 1f);
			float num5 = this.LQHQFLHFQLO / (this.GELCLJPKPPB * num4);
			if (num5 < num)
			{
				num2 = num5;
			}
		}
		if (Mathf.Abs(num - num2) > 0.0001f)
		{
			float smoothTime = (num2 >= num) ? this.OMKJQQEBGJH : this.PIHLKIFBFNJ;
			num2 = Mathf.SmoothDamp(num, num2, ref this.BFDQKNMIIKD, smoothTime, float.PositiveInfinity, GPFIDEJEMEG);
		}
		float num6 = num2 - base.GPONHFNLHCN.PGKODNCDNJQ.y / 2f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.PGKODNCDNJQ.y;
		return HELGNNDIDCI + num6;
	}

	// Token: 0x0600754A RID: 30026 RVA: 0x00384630 File Offset: 0x00382830
	public float QKFGOPQJHLG(float GPFIDEJEMEG, float HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		if (this.BHHDKFGKGKG == base.GPONHFNLHCN.PGKODNCDNJQ.y)
		{
			this.BFDQKNMIIKD = 1711f;
		}
		this.QNNCCGLQBMQ = (this.NMOHPQICBEO - this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM))).magnitude / GPFIDEJEMEG;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		float num = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1772f;
		float num2 = num;
		if (this.QNNCCGLQBMQ > this.HQMPDPFCLNP)
		{
			float value = (this.QNNCCGLQBMQ - this.HQMPDPFCLNP) / (this.BNQMPKGODHM - this.HQMPDPFCLNP);
			float num3 = this.LQHQFLHFQLO * (1184f + this.OPJQBGHMFPN - 1720f) * Mathf.Clamp01(value);
			if (num3 > num)
			{
				num2 = num3;
			}
		}
		else
		{
			float num4 = (213f - this.QNNCCGLQBMQ / this.HQMPDPFCLNP).PMNDBPOMOGG(1098f, 1531f, 854f, 1037f);
			float num5 = this.LQHQFLHFQLO / (this.GELCLJPKPPB * num4);
			if (num5 < num)
			{
				num2 = num5;
			}
		}
		if (Mathf.Abs(num - num2) > 1519f)
		{
			float smoothTime = (num2 >= num) ? this.OMKJQQEBGJH : this.PIHLKIFBFNJ;
			num2 = Mathf.SmoothDamp(num, num2, ref this.BFDQKNMIIKD, smoothTime, 201f, GPFIDEJEMEG);
		}
		float num6 = num2 - base.GPONHFNLHCN.FOOEEHDJBQN().y / 1199f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.FOOEEHDJBQN().y;
		return HELGNNDIDCI + num6;
	}

	// Token: 0x0600754B RID: 30027 RVA: 0x0002A37D File Offset: 0x0002857D
	protected virtual void HGFCQIKLPDO()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQIPIPOJKDH(this);
		}
	}

	// Token: 0x0600754C RID: 30028 RVA: 0x0002A375 File Offset: 0x00028575
	public int MNKCOPLGEQI()
	{
		return this.OCCGDPBDDDD;
	}

	// Token: 0x0600754D RID: 30029 RVA: 0x00384838 File Offset: 0x00382A38
	public float GKCPHLNGKQM(float GPFIDEJEMEG, float HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		if (this.BHHDKFGKGKG == base.GPONHFNLHCN.FOOEEHDJBQN().y)
		{
			this.BFDQKNMIIKD = 1084f;
		}
		this.QNNCCGLQBMQ = (this.NMOHPQICBEO - this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM))).magnitude / GPFIDEJEMEG;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		float num = base.GPONHFNLHCN.PGKODNCDNJQ.y * 252f;
		float num2 = num;
		if (this.QNNCCGLQBMQ > this.HQMPDPFCLNP)
		{
			float value = (this.QNNCCGLQBMQ - this.HQMPDPFCLNP) / (this.BNQMPKGODHM - this.HQMPDPFCLNP);
			float num3 = this.LQHQFLHFQLO * (1601f + this.OPJQBGHMFPN - 1986f) * Mathf.Clamp01(value);
			if (num3 > num)
			{
				num2 = num3;
			}
		}
		else
		{
			float num4 = (1911f - this.QNNCCGLQBMQ / this.HQMPDPFCLNP).PMNDBPOMOGG(975f, 1428f, 320f, 1782f);
			float num5 = this.LQHQFLHFQLO / (this.GELCLJPKPPB * num4);
			if (num5 < num)
			{
				num2 = num5;
			}
		}
		if (Mathf.Abs(num - num2) > 757f)
		{
			float smoothTime = (num2 >= num) ? this.OMKJQQEBGJH : this.PIHLKIFBFNJ;
			num2 = Mathf.SmoothDamp(num, num2, ref this.BFDQKNMIIKD, smoothTime, 785f, GPFIDEJEMEG);
		}
		float num6 = num2 - base.GPONHFNLHCN.PGKODNCDNJQ.y / 568f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.FOOEEHDJBQN().y;
		return HELGNNDIDCI + num6;
	}

	// Token: 0x0600754E RID: 30030 RVA: 0x00384A40 File Offset: 0x00382C40
	protected virtual void JENKEGOEEHO()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1131f;
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		base.GPONHFNLHCN.COLMPQPBLFH(this);
	}

	// Token: 0x0600754F RID: 30031 RVA: 0x00384AD8 File Offset: 0x00382CD8
	public virtual void JIILMEOLIFB()
	{
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		this.BFDQKNMIIKD = 551f;
	}

	// Token: 0x06007550 RID: 30032 RVA: 0x00384B3C File Offset: 0x00382D3C
	protected virtual void BEHGFNEDJDF()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 545f;
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		base.GPONHFNLHCN.COLMPQPBLFH(this);
	}

	// Token: 0x06007551 RID: 30033 RVA: 0x00384BD4 File Offset: 0x00382DD4
	protected virtual void LEJQMIECFCH()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 465f;
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		base.GPONHFNLHCN.COLMPQPBLFH(this);
	}

	// Token: 0x06007552 RID: 30034 RVA: 0x00384C6C File Offset: 0x00382E6C
	protected virtual void PEOBQCMFLML()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 164f;
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		base.GPONHFNLHCN.COLMPQPBLFH(this);
	}

	// Token: 0x06007553 RID: 30035 RVA: 0x0002A375 File Offset: 0x00028575
	public int CIBJJKJEPDF()
	{
		return this.OCCGDPBDDDD;
	}

	// Token: 0x06007554 RID: 30036 RVA: 0x00384D04 File Offset: 0x00382F04
	public float FFGOBMIGEHM(float GPFIDEJEMEG, float HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		if (this.BHHDKFGKGKG == base.GPONHFNLHCN.PGKODNCDNJQ.y)
		{
			this.BFDQKNMIIKD = 1588f;
		}
		this.QNNCCGLQBMQ = (this.NMOHPQICBEO - this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM))).magnitude / GPFIDEJEMEG;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		float num = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1280f;
		float num2 = num;
		if (this.QNNCCGLQBMQ > this.HQMPDPFCLNP)
		{
			float value = (this.QNNCCGLQBMQ - this.HQMPDPFCLNP) / (this.BNQMPKGODHM - this.HQMPDPFCLNP);
			float num3 = this.LQHQFLHFQLO * (526f + this.OPJQBGHMFPN - 1363f) * Mathf.Clamp01(value);
			if (num3 > num)
			{
				num2 = num3;
			}
		}
		else
		{
			float num4 = (1466f - this.QNNCCGLQBMQ / this.HQMPDPFCLNP).PMNDBPOMOGG(548f, 1053f, 1154f, 443f);
			float num5 = this.LQHQFLHFQLO / (this.GELCLJPKPPB * num4);
			if (num5 < num)
			{
				num2 = num5;
			}
		}
		if (Mathf.Abs(num - num2) > 802f)
		{
			float smoothTime = (num2 >= num) ? this.OMKJQQEBGJH : this.PIHLKIFBFNJ;
			num2 = Mathf.SmoothDamp(num, num2, ref this.BFDQKNMIIKD, smoothTime, 503f, GPFIDEJEMEG);
		}
		float num6 = num2 - base.GPONHFNLHCN.PGKODNCDNJQ.y / 1344f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.PGKODNCDNJQ.y;
		return HELGNNDIDCI + num6;
	}

	// Token: 0x06007556 RID: 30038 RVA: 0x00384F0C File Offset: 0x0038310C
	protected virtual void HFBHKNOCLOE()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1686f;
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		base.GPONHFNLHCN.FHCNNFQNMLD(this);
	}

	// Token: 0x06007557 RID: 30039 RVA: 0x00384FA4 File Offset: 0x003831A4
	protected virtual void LJBKGHHLMFB()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 910f;
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		base.GPONHFNLHCN.COLMPQPBLFH(this);
	}

	// Token: 0x06007558 RID: 30040 RVA: 0x0038503C File Offset: 0x0038323C
	public virtual void OMNCOCDELBP()
	{
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		this.BFDQKNMIIKD = 1033f;
	}

	// Token: 0x06007559 RID: 30041 RVA: 0x0002A37D File Offset: 0x0002857D
	protected virtual void DGJDQDOFNFP()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQIPIPOJKDH(this);
		}
	}

	// Token: 0x0600755A RID: 30042 RVA: 0x003850A0 File Offset: 0x003832A0
	public float BMOLKJELIIO(float GPFIDEJEMEG, float HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		if (this.BHHDKFGKGKG == base.GPONHFNLHCN.FOOEEHDJBQN().y)
		{
			this.BFDQKNMIIKD = 1079f;
		}
		this.QNNCCGLQBMQ = (this.NMOHPQICBEO - this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM))).magnitude / GPFIDEJEMEG;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		float num = base.GPONHFNLHCN.PGKODNCDNJQ.y * 411f;
		float num2 = num;
		if (this.QNNCCGLQBMQ > this.HQMPDPFCLNP)
		{
			float value = (this.QNNCCGLQBMQ - this.HQMPDPFCLNP) / (this.BNQMPKGODHM - this.HQMPDPFCLNP);
			float num3 = this.LQHQFLHFQLO * (1126f + this.OPJQBGHMFPN - 54f) * Mathf.Clamp01(value);
			if (num3 > num)
			{
				num2 = num3;
			}
		}
		else
		{
			float num4 = (1084f - this.QNNCCGLQBMQ / this.HQMPDPFCLNP).PMNDBPOMOGG(1794f, 1485f, 1916f, 3f);
			float num5 = this.LQHQFLHFQLO / (this.GELCLJPKPPB * num4);
			if (num5 < num)
			{
				num2 = num5;
			}
		}
		if (Mathf.Abs(num - num2) > 1975f)
		{
			float smoothTime = (num2 >= num) ? this.OMKJQQEBGJH : this.PIHLKIFBFNJ;
			num2 = Mathf.SmoothDamp(num, num2, ref this.BFDQKNMIIKD, smoothTime, 1015f, GPFIDEJEMEG);
		}
		float num6 = num2 - base.GPONHFNLHCN.FOOEEHDJBQN().y / 547f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.PGKODNCDNJQ.y;
		return HELGNNDIDCI + num6;
	}

	// Token: 0x0600755B RID: 30043 RVA: 0x003852A8 File Offset: 0x003834A8
	public virtual void NJHMCHEOCDD()
	{
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		this.BFDQKNMIIKD = 767f;
	}

	// Token: 0x0600755C RID: 30044 RVA: 0x0002A34B File Offset: 0x0002854B
	protected virtual void FIMPCGCJHIC()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.ENQCBPLGIQO(this);
		}
	}

	// Token: 0x0600755D RID: 30045 RVA: 0x0002A37D File Offset: 0x0002857D
	protected virtual void MJPHLNPMKLF()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQIPIPOJKDH(this);
		}
	}

	// Token: 0x0600755E RID: 30046 RVA: 0x0002A34B File Offset: 0x0002854B
	protected virtual void JEMMIEIENOB()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.ENQCBPLGIQO(this);
		}
	}

	// Token: 0x0600755F RID: 30047 RVA: 0x0038530C File Offset: 0x0038350C
	public float HJNKEICQCDP(float GPFIDEJEMEG, float HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		if (this.BHHDKFGKGKG == base.GPONHFNLHCN.FOOEEHDJBQN().y)
		{
			this.BFDQKNMIIKD = 749f;
		}
		this.QNNCCGLQBMQ = (this.NMOHPQICBEO - this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM))).magnitude / GPFIDEJEMEG;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		float num = base.GPONHFNLHCN.FOOEEHDJBQN().y * 824f;
		float num2 = num;
		if (this.QNNCCGLQBMQ > this.HQMPDPFCLNP)
		{
			float value = (this.QNNCCGLQBMQ - this.HQMPDPFCLNP) / (this.BNQMPKGODHM - this.HQMPDPFCLNP);
			float num3 = this.LQHQFLHFQLO * (487f + this.OPJQBGHMFPN - 580f) * Mathf.Clamp01(value);
			if (num3 > num)
			{
				num2 = num3;
			}
		}
		else
		{
			float num4 = (317f - this.QNNCCGLQBMQ / this.HQMPDPFCLNP).PMNDBPOMOGG(1665f, 1600f, 616f, 1344f);
			float num5 = this.LQHQFLHFQLO / (this.GELCLJPKPPB * num4);
			if (num5 < num)
			{
				num2 = num5;
			}
		}
		if (Mathf.Abs(num - num2) > 921f)
		{
			float smoothTime = (num2 >= num) ? this.OMKJQQEBGJH : this.PIHLKIFBFNJ;
			num2 = Mathf.SmoothDamp(num, num2, ref this.BFDQKNMIIKD, smoothTime, 129f, GPFIDEJEMEG);
		}
		float num6 = num2 - base.GPONHFNLHCN.PGKODNCDNJQ.y / 677f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.PGKODNCDNJQ.y;
		return HELGNNDIDCI + num6;
	}

	// Token: 0x06007560 RID: 30048 RVA: 0x0002A34B File Offset: 0x0002854B
	protected virtual void DQPLIHHGNKM()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.ENQCBPLGIQO(this);
		}
	}

	// Token: 0x06007561 RID: 30049 RVA: 0x0002A34B File Offset: 0x0002854B
	protected virtual void JJNJGJEDBMF()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.ENQCBPLGIQO(this);
		}
	}

	// Token: 0x06007562 RID: 30050 RVA: 0x0002A375 File Offset: 0x00028575
	public int LMNEENNMGKC()
	{
		return this.OCCGDPBDDDD;
	}

	// Token: 0x06007563 RID: 30051 RVA: 0x0002A375 File Offset: 0x00028575
	public int FOCIBHEPKEF()
	{
		return this.OCCGDPBDDDD;
	}

	// Token: 0x06007564 RID: 30052 RVA: 0x0002A37D File Offset: 0x0002857D
	protected virtual void QJELMIKNIIE()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQIPIPOJKDH(this);
		}
	}

	// Token: 0x06007565 RID: 30053 RVA: 0x0002A37D File Offset: 0x0002857D
	protected virtual void NQEFIQFNGCK()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQIPIPOJKDH(this);
		}
	}

	// Token: 0x06007566 RID: 30054 RVA: 0x00385514 File Offset: 0x00383714
	protected virtual void BBKNQONEBJB()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 1347f;
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		base.GPONHFNLHCN.COLMPQPBLFH(this);
	}

	// Token: 0x06007567 RID: 30055 RVA: 0x003855AC File Offset: 0x003837AC
	protected virtual void IPEEHKMMPCD()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 39f;
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		base.GPONHFNLHCN.FHCNNFQNMLD(this);
	}

	// Token: 0x06007568 RID: 30056 RVA: 0x00385644 File Offset: 0x00383844
	protected virtual void HPMKHDFJMNQ()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 1992f;
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		base.GPONHFNLHCN.FHCNNFQNMLD(this);
	}

	// Token: 0x06007569 RID: 30057 RVA: 0x003856DC File Offset: 0x003838DC
	public virtual void OPGLHFPNIGF()
	{
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		this.BFDQKNMIIKD = 1585f;
	}

	// Token: 0x0600756A RID: 30058 RVA: 0x00385740 File Offset: 0x00383940
	public virtual void QQQBQLBMNIF()
	{
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		this.BFDQKNMIIKD = 1744f;
	}

	// Token: 0x0600756B RID: 30059 RVA: 0x003857A4 File Offset: 0x003839A4
	public float QJMFDDLJIGG(float GPFIDEJEMEG, float HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		if (this.BHHDKFGKGKG == base.GPONHFNLHCN.FOOEEHDJBQN().y)
		{
			this.BFDQKNMIIKD = 1489f;
		}
		this.QNNCCGLQBMQ = (this.NMOHPQICBEO - this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM))).magnitude / GPFIDEJEMEG;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		float num = base.GPONHFNLHCN.FOOEEHDJBQN().y * 217f;
		float num2 = num;
		if (this.QNNCCGLQBMQ > this.HQMPDPFCLNP)
		{
			float value = (this.QNNCCGLQBMQ - this.HQMPDPFCLNP) / (this.BNQMPKGODHM - this.HQMPDPFCLNP);
			float num3 = this.LQHQFLHFQLO * (1181f + this.OPJQBGHMFPN - 1444f) * Mathf.Clamp01(value);
			if (num3 > num)
			{
				num2 = num3;
			}
		}
		else
		{
			float num4 = (785f - this.QNNCCGLQBMQ / this.HQMPDPFCLNP).PMNDBPOMOGG(1116f, 97f, 1087f, 1067f);
			float num5 = this.LQHQFLHFQLO / (this.GELCLJPKPPB * num4);
			if (num5 < num)
			{
				num2 = num5;
			}
		}
		if (Mathf.Abs(num - num2) > 675f)
		{
			float smoothTime = (num2 >= num) ? this.OMKJQQEBGJH : this.PIHLKIFBFNJ;
			num2 = Mathf.SmoothDamp(num, num2, ref this.BFDQKNMIIKD, smoothTime, 302f, GPFIDEJEMEG);
		}
		float num6 = num2 - base.GPONHFNLHCN.PGKODNCDNJQ.y / 234f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.FOOEEHDJBQN().y;
		return HELGNNDIDCI + num6;
	}

	// Token: 0x0600756C RID: 30060 RVA: 0x003859AC File Offset: 0x00383BAC
	protected virtual void COGJQEEGCFB()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1875f;
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		base.GPONHFNLHCN.COLMPQPBLFH(this);
	}

	// Token: 0x0600756D RID: 30061 RVA: 0x0002A375 File Offset: 0x00028575
	public int EECDOOGIPGE()
	{
		return this.OCCGDPBDDDD;
	}

	// Token: 0x0600756E RID: 30062 RVA: 0x0002A34B File Offset: 0x0002854B
	protected virtual void OJNNLMONFQN()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.ENQCBPLGIQO(this);
		}
	}

	// Token: 0x0600756F RID: 30063 RVA: 0x0002A375 File Offset: 0x00028575
	public int OGIQEFBIPLK()
	{
		return this.OCCGDPBDDDD;
	}

	// Token: 0x06007570 RID: 30064 RVA: 0x00385A44 File Offset: 0x00383C44
	public virtual void KCGGEKPHMMN()
	{
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		this.BFDQKNMIIKD = 822f;
	}

	// Token: 0x06007571 RID: 30065 RVA: 0x0002A36C File Offset: 0x0002856C
	public void HBGDDOJQDDH(int BGBMIEJJQKC)
	{
		this.OCCGDPBDDDD = BGBMIEJJQKC;
	}

	// Token: 0x06007572 RID: 30066 RVA: 0x0002A375 File Offset: 0x00028575
	public int IQIIJFKFIJD()
	{
		return this.OCCGDPBDDDD;
	}

	// Token: 0x06007573 RID: 30067 RVA: 0x00385AA8 File Offset: 0x00383CA8
	public float LCLEMFFQBLL(float GPFIDEJEMEG, float HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		if (this.BHHDKFGKGKG == base.GPONHFNLHCN.PGKODNCDNJQ.y)
		{
			this.BFDQKNMIIKD = 55f;
		}
		this.QNNCCGLQBMQ = (this.NMOHPQICBEO - this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM))).magnitude / GPFIDEJEMEG;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		float num = base.GPONHFNLHCN.FOOEEHDJBQN().y * 1839f;
		float num2 = num;
		if (this.QNNCCGLQBMQ > this.HQMPDPFCLNP)
		{
			float value = (this.QNNCCGLQBMQ - this.HQMPDPFCLNP) / (this.BNQMPKGODHM - this.HQMPDPFCLNP);
			float num3 = this.LQHQFLHFQLO * (1446f + this.OPJQBGHMFPN - 1836f) * Mathf.Clamp01(value);
			if (num3 > num)
			{
				num2 = num3;
			}
		}
		else
		{
			float num4 = (1842f - this.QNNCCGLQBMQ / this.HQMPDPFCLNP).PMNDBPOMOGG(579f, 54f, 1332f, 1593f);
			float num5 = this.LQHQFLHFQLO / (this.GELCLJPKPPB * num4);
			if (num5 < num)
			{
				num2 = num5;
			}
		}
		if (Mathf.Abs(num - num2) > 526f)
		{
			float smoothTime = (num2 >= num) ? this.OMKJQQEBGJH : this.PIHLKIFBFNJ;
			num2 = Mathf.SmoothDamp(num, num2, ref this.BFDQKNMIIKD, smoothTime, 1636f, GPFIDEJEMEG);
		}
		float num6 = num2 - base.GPONHFNLHCN.PGKODNCDNJQ.y / 1324f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.PGKODNCDNJQ.y;
		return HELGNNDIDCI + num6;
	}

	// Token: 0x06007574 RID: 30068 RVA: 0x0002A34B File Offset: 0x0002854B
	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.ENQCBPLGIQO(this);
		}
	}

	// Token: 0x06007575 RID: 30069 RVA: 0x0002A36C File Offset: 0x0002856C
	public void GIGJMDQOKED(int BGBMIEJJQKC)
	{
		this.OCCGDPBDDDD = BGBMIEJJQKC;
	}

	// Token: 0x06007576 RID: 30070 RVA: 0x0002A36C File Offset: 0x0002856C
	public void DFEIOPNKBJL(int BGBMIEJJQKC)
	{
		this.OCCGDPBDDDD = BGBMIEJJQKC;
	}

	// Token: 0x06007577 RID: 30071 RVA: 0x00385CB0 File Offset: 0x00383EB0
	public float NJJOKJIDJBO(float GPFIDEJEMEG, float HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		if (this.BHHDKFGKGKG == base.GPONHFNLHCN.PGKODNCDNJQ.y)
		{
			this.BFDQKNMIIKD = 1762f;
		}
		this.QNNCCGLQBMQ = (this.NMOHPQICBEO - this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM))).magnitude / GPFIDEJEMEG;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		float num = base.GPONHFNLHCN.FOOEEHDJBQN().y * 668f;
		float num2 = num;
		if (this.QNNCCGLQBMQ > this.HQMPDPFCLNP)
		{
			float value = (this.QNNCCGLQBMQ - this.HQMPDPFCLNP) / (this.BNQMPKGODHM - this.HQMPDPFCLNP);
			float num3 = this.LQHQFLHFQLO * (1692f + this.OPJQBGHMFPN - 1652f) * Mathf.Clamp01(value);
			if (num3 > num)
			{
				num2 = num3;
			}
		}
		else
		{
			float num4 = (1418f - this.QNNCCGLQBMQ / this.HQMPDPFCLNP).PMNDBPOMOGG(551f, 342f, 538f, 1070f);
			float num5 = this.LQHQFLHFQLO / (this.GELCLJPKPPB * num4);
			if (num5 < num)
			{
				num2 = num5;
			}
		}
		if (Mathf.Abs(num - num2) > 446f)
		{
			float smoothTime = (num2 >= num) ? this.OMKJQQEBGJH : this.PIHLKIFBFNJ;
			num2 = Mathf.SmoothDamp(num, num2, ref this.BFDQKNMIIKD, smoothTime, 778f, GPFIDEJEMEG);
		}
		float num6 = num2 - base.GPONHFNLHCN.PGKODNCDNJQ.y / 1518f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.FOOEEHDJBQN().y;
		return HELGNNDIDCI + num6;
	}

	// Token: 0x06007578 RID: 30072 RVA: 0x0002A36C File Offset: 0x0002856C
	public void EILBFOMGCCQ(int BGBMIEJJQKC)
	{
		this.OCCGDPBDDDD = BGBMIEJJQKC;
	}

	// Token: 0x06007579 RID: 30073 RVA: 0x0002A36C File Offset: 0x0002856C
	public void EDMDKHGKCGE(int BGBMIEJJQKC)
	{
		this.OCCGDPBDDDD = BGBMIEJJQKC;
	}

	// Token: 0x0600757A RID: 30074 RVA: 0x00385EB8 File Offset: 0x003840B8
	public float GIJPPBILENH(float GPFIDEJEMEG, float HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		if (this.BHHDKFGKGKG == base.GPONHFNLHCN.PGKODNCDNJQ.y)
		{
			this.BFDQKNMIIKD = 1892f;
		}
		this.QNNCCGLQBMQ = (this.NMOHPQICBEO - this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM))).magnitude / GPFIDEJEMEG;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		float num = base.GPONHFNLHCN.FOOEEHDJBQN().y * 5f;
		float num2 = num;
		if (this.QNNCCGLQBMQ > this.HQMPDPFCLNP)
		{
			float value = (this.QNNCCGLQBMQ - this.HQMPDPFCLNP) / (this.BNQMPKGODHM - this.HQMPDPFCLNP);
			float num3 = this.LQHQFLHFQLO * (1182f + this.OPJQBGHMFPN - 1987f) * Mathf.Clamp01(value);
			if (num3 > num)
			{
				num2 = num3;
			}
		}
		else
		{
			float num4 = (1440f - this.QNNCCGLQBMQ / this.HQMPDPFCLNP).PMNDBPOMOGG(822f, 613f, 111f, 549f);
			float num5 = this.LQHQFLHFQLO / (this.GELCLJPKPPB * num4);
			if (num5 < num)
			{
				num2 = num5;
			}
		}
		if (Mathf.Abs(num - num2) > 723f)
		{
			float smoothTime = (num2 >= num) ? this.OMKJQQEBGJH : this.PIHLKIFBFNJ;
			num2 = Mathf.SmoothDamp(num, num2, ref this.BFDQKNMIIKD, smoothTime, 1532f, GPFIDEJEMEG);
		}
		float num6 = num2 - base.GPONHFNLHCN.PGKODNCDNJQ.y / 1099f;
		this.BHHDKFGKGKG = base.GPONHFNLHCN.FOOEEHDJBQN().y;
		return HELGNNDIDCI + num6;
	}

	// Token: 0x0600757B RID: 30075 RVA: 0x0002A375 File Offset: 0x00028575
	public int KJPGEGPHGNM()
	{
		return this.OCCGDPBDDDD;
	}

	// Token: 0x0600757C RID: 30076 RVA: 0x0002A36C File Offset: 0x0002856C
	public void OCLDGJENEMG(int BGBMIEJJQKC)
	{
		this.OCCGDPBDDDD = BGBMIEJJQKC;
	}

	// Token: 0x0600757D RID: 30077 RVA: 0x0002A375 File Offset: 0x00028575
	public int ENLOBDMDIQE()
	{
		return this.OCCGDPBDDDD;
	}

	// Token: 0x0600757E RID: 30078 RVA: 0x003860C0 File Offset: 0x003842C0
	protected virtual void IHGDMCFDINH()
	{
		base.Awake();
		if (base.GPONHFNLHCN == null)
		{
			return;
		}
		this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 922f;
		this.BHHDKFGKGKG = this.LQHQFLHFQLO;
		this.NMOHPQICBEO = this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM));
		base.GPONHFNLHCN.COLMPQPBLFH(this);
	}

	// Token: 0x0400193D RID: 6461
	public static string OPGNGFNJDDP = "Speed Based Zoom";

	// Token: 0x0400193E RID: 6462
	[Tooltip("The speed at which the camera will reach it's max zoom out.")]
	public float BNQMPKGODHM = 5f;

	// Token: 0x0400193F RID: 6463
	[Tooltip("Below this speed the camera zooms in. Above this speed the camera will start zooming out.")]
	public float HQMPDPFCLNP = 2f;

	// Token: 0x04001940 RID: 6464
	[Tooltip("Represents how smooth the zoom in of the camera should be. The lower the number the quickest the zoom is.")]
	[Range(0f, 3f)]
	public float PIHLKIFBFNJ = 1f;

	// Token: 0x04001941 RID: 6465
	[Tooltip("Represents how smooth the zoom out of the camera should be. The lower the number the quickest the zoom is.")]
	[Range(0f, 3f)]
	public float OMKJQQEBGJH = 1f;

	// Token: 0x04001942 RID: 6466
	[Tooltip("Represents the maximum amount the camera should zoom in when the camera speed is below SpeedForZoomIn")]
	public float GELCLJPKPPB = 2f;

	// Token: 0x04001943 RID: 6467
	[Tooltip("Represents the maximum amount the camera should zoom out when the camera speed is equal to SpeedForZoomOut")]
	public float OPJQBGHMFPN = 2f;

	// Token: 0x04001944 RID: 6468
	private float BFDQKNMIIKD;

	// Token: 0x04001945 RID: 6469
	private float LQHQFLHFQLO;

	// Token: 0x04001946 RID: 6470
	private float BHHDKFGKGKG;

	// Token: 0x04001947 RID: 6471
	private Vector3 NMOHPQICBEO;

	// Token: 0x04001948 RID: 6472
	[HideInInspector]
	public float QNNCCGLQBMQ;

	// Token: 0x04001949 RID: 6473
	private int OCCGDPBDDDD = 1000;
}
