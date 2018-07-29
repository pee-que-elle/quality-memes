using System;
using UnityEngine;

// Token: 0x02000343 RID: 835
[HelpURL("http://www.procamera2d.com/user-guide/extension-camera-window/")]
public class GFGLQFHLHNC : BNEFIOCKQOE, LIJCFDMDDIJ
{
	// Token: 0x06006E07 RID: 28167 RVA: 0x00028E05 File Offset: 0x00027005
	public int GLQDOPJNMFF()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06006E08 RID: 28168 RVA: 0x0035950C File Offset: 0x0035770C
	private Rect MCJMOJOOOBQ(Rect QDMEGCJHMFM, Vector2 EGFDHDCCNEF, Transform BPIDBPDCOIE, bool EQDEOJCLNKH)
	{
		Vector2 vector = Vector2.Scale(new Vector2(QDMEGCJHMFM.width, QDMEGCJHMFM.height), (!EQDEOJCLNKH) ? Vector2.one : EGFDHDCCNEF);
		float x = this.FKGNBCKJPQO(BPIDBPDCOIE.localPosition) - vector.x / 1226f + QDMEGCJHMFM.x * ((!EQDEOJCLNKH) ? 764f : EGFDHDCCNEF.x);
		float y = this.JNBBJCLFFBB(BPIDBPDCOIE.localPosition) - vector.y / 1153f + QDMEGCJHMFM.y * ((!EQDEOJCLNKH) ? 176f : EGFDHDCCNEF.y);
		return new Rect(x, y, vector.x, vector.y);
	}

	// Token: 0x06006E09 RID: 28169 RVA: 0x00028E0D File Offset: 0x0002700D
	public void HLJGPGIGCIH(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x06006E0B RID: 28171 RVA: 0x00028E0D File Offset: 0x0002700D
	public void HIMCOFMFEOF(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x06006E0C RID: 28172 RVA: 0x003595CC File Offset: 0x003577CC
	public Vector3 NEQJKQMIBGD(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		this.FQHNHKDNONQ = this.MCJMOJOOOBQ(this.JHQICBCGQPK, base.GPONHFNLHCN.FOOEEHDJBQN(), this.FHNBJCNLJCN, this.GHQIHIEQQFL);
		float arg = 1971f;
		if (base.GPONHFNLHCN.EKNKJLCLLCQ().x >= this.FQHNHKDNONQ.x + this.FQHNHKDNONQ.width)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.width / 1046f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 54f : base.GPONHFNLHCN.FOOEEHDJBQN().x));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.x <= this.FQHNHKDNONQ.x)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.width / 1180f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 594f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		float arg2 = 936f;
		if (base.GPONHFNLHCN.EKNKJLCLLCQ().y >= this.FQHNHKDNONQ.y + this.FQHNHKDNONQ.height)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.height / 1264f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 895f : base.GPONHFNLHCN.FOOEEHDJBQN().y));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.y <= this.FQHNHKDNONQ.y)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.height / 496f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 123f : base.GPONHFNLHCN.PGKODNCDNJQ.y));
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006E0D RID: 28173 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void MJPHLNPMKLF()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x06006E0E RID: 28174 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void QJELMIKNIIE()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x06006E0F RID: 28175 RVA: 0x00359884 File Offset: 0x00357A84
	public Vector3 MKKGHGDNEOK(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		this.FQHNHKDNONQ = this.KDJJMFONPDB(this.JHQICBCGQPK, base.GPONHFNLHCN.PGKODNCDNJQ, this.FHNBJCNLJCN, this.GHQIHIEQQFL);
		float arg = 0f;
		if (base.GPONHFNLHCN.EQCLOIQEDLC.x >= this.FQHNHKDNONQ.x + this.FQHNHKDNONQ.width)
		{
			arg = base.GPONHFNLHCN.EQCLOIQEDLC.x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.width / 2f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 1f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.x <= this.FQHNHKDNONQ.x)
		{
			arg = base.GPONHFNLHCN.EQCLOIQEDLC.x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.width / 2f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 1f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		float arg2 = 0f;
		if (base.GPONHFNLHCN.EQCLOIQEDLC.y >= this.FQHNHKDNONQ.y + this.FQHNHKDNONQ.height)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.height / 2f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 1f : base.GPONHFNLHCN.PGKODNCDNJQ.y));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.y <= this.FQHNHKDNONQ.y)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.height / 2f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 1f : base.GPONHFNLHCN.PGKODNCDNJQ.y));
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006E10 RID: 28176 RVA: 0x00028E05 File Offset: 0x00027005
	public int CDQQPOMKIMJ()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06006E11 RID: 28177 RVA: 0x00359B3C File Offset: 0x00357D3C
	public Vector3 MJHEMBLQHGF(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		this.FQHNHKDNONQ = this.DFNCEDNGQEN(this.JHQICBCGQPK, base.GPONHFNLHCN.FOOEEHDJBQN(), this.FHNBJCNLJCN, this.GHQIHIEQQFL);
		float arg = 694f;
		if (base.GPONHFNLHCN.EKNKJLCLLCQ().x >= this.FQHNHKDNONQ.x + this.FQHNHKDNONQ.width)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.width / 867f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 1197f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		else if (base.GPONHFNLHCN.EKNKJLCLLCQ().x <= this.FQHNHKDNONQ.x)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.width / 1276f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 74f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		float arg2 = 1532f;
		if (base.GPONHFNLHCN.EQCLOIQEDLC.y >= this.FQHNHKDNONQ.y + this.FQHNHKDNONQ.height)
		{
			arg2 = base.GPONHFNLHCN.EKNKJLCLLCQ().y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.height / 890f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 745f : base.GPONHFNLHCN.PGKODNCDNJQ.y));
		}
		else if (base.GPONHFNLHCN.EKNKJLCLLCQ().y <= this.FQHNHKDNONQ.y)
		{
			arg2 = base.GPONHFNLHCN.EKNKJLCLLCQ().y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.height / 518f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 349f : base.GPONHFNLHCN.FOOEEHDJBQN().y));
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006E12 RID: 28178 RVA: 0x00028E05 File Offset: 0x00027005
	public int NMFEIQBEDEN()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06006E13 RID: 28179 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void CIOMMELIPIP()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x06006E14 RID: 28180 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void CGGDNNKBIJC()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x06006E15 RID: 28181 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void JEDENEOLFBJ()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x06006E16 RID: 28182 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void BBFBCBMEJEN()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x06006E17 RID: 28183 RVA: 0x00028E0D File Offset: 0x0002700D
	public void ICFMQIMKCPO(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x06006E18 RID: 28184 RVA: 0x00359DF4 File Offset: 0x00357FF4
	private Rect KDJJMFONPDB(Rect QDMEGCJHMFM, Vector2 EGFDHDCCNEF, Transform BPIDBPDCOIE, bool EQDEOJCLNKH)
	{
		Vector2 vector = Vector2.Scale(new Vector2(QDMEGCJHMFM.width, QDMEGCJHMFM.height), (!EQDEOJCLNKH) ? Vector2.one : EGFDHDCCNEF);
		float x = this.FKGNBCKJPQO(BPIDBPDCOIE.localPosition) - vector.x / 2f + QDMEGCJHMFM.x * ((!EQDEOJCLNKH) ? 1f : EGFDHDCCNEF.x);
		float y = this.JNBBJCLFFBB(BPIDBPDCOIE.localPosition) - vector.y / 2f + QDMEGCJHMFM.y * ((!EQDEOJCLNKH) ? 1f : EGFDHDCCNEF.y);
		return new Rect(x, y, vector.x, vector.y);
	}

	// Token: 0x06006E19 RID: 28185 RVA: 0x00028E44 File Offset: 0x00027044
	protected override void OnDestroy()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x06006E1A RID: 28186 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void ONKEDLLOMCE()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x06006E1B RID: 28187 RVA: 0x00028E0D File Offset: 0x0002700D
	public void IDEGEMELELN(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x06006E1C RID: 28188 RVA: 0x00028E05 File Offset: 0x00027005
	public int JNMDQMLLPBI()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06006E1D RID: 28189 RVA: 0x00359EB4 File Offset: 0x003580B4
	private Rect MPDKFLDBEHM(Rect QDMEGCJHMFM, Vector2 EGFDHDCCNEF, Transform BPIDBPDCOIE, bool EQDEOJCLNKH)
	{
		Vector2 vector = Vector2.Scale(new Vector2(QDMEGCJHMFM.width, QDMEGCJHMFM.height), (!EQDEOJCLNKH) ? Vector2.one : EGFDHDCCNEF);
		float x = this.FKGNBCKJPQO(BPIDBPDCOIE.localPosition) - vector.x / 1315f + QDMEGCJHMFM.x * ((!EQDEOJCLNKH) ? 665f : EGFDHDCCNEF.x);
		float y = this.JNBBJCLFFBB(BPIDBPDCOIE.localPosition) - vector.y / 494f + QDMEGCJHMFM.y * ((!EQDEOJCLNKH) ? 1729f : EGFDHDCCNEF.y);
		return new Rect(x, y, vector.x, vector.y);
	}

	// Token: 0x06006E1E RID: 28190 RVA: 0x00359F74 File Offset: 0x00358174
	public Vector3 NMIBIICFOIH(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		this.FQHNHKDNONQ = this.IMMKGCIDPQE(this.JHQICBCGQPK, base.GPONHFNLHCN.PGKODNCDNJQ, this.FHNBJCNLJCN, this.GHQIHIEQQFL);
		float arg = 1436f;
		if (base.GPONHFNLHCN.EQCLOIQEDLC.x >= this.FQHNHKDNONQ.x + this.FQHNHKDNONQ.width)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.width / 82f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 1285f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.x <= this.FQHNHKDNONQ.x)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.width / 384f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 194f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		float arg2 = 1567f;
		if (base.GPONHFNLHCN.EKNKJLCLLCQ().y >= this.FQHNHKDNONQ.y + this.FQHNHKDNONQ.height)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.height / 137f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 1908f : base.GPONHFNLHCN.PGKODNCDNJQ.y));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.y <= this.FQHNHKDNONQ.y)
		{
			arg2 = base.GPONHFNLHCN.EKNKJLCLLCQ().y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.height / 511f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 330f : base.GPONHFNLHCN.PGKODNCDNJQ.y));
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x170003CD RID: 973
	// (get) Token: 0x06006E1F RID: 28191 RVA: 0x00028E05 File Offset: 0x00027005
	// (set) Token: 0x06006E51 RID: 28241 RVA: 0x00028E0D File Offset: 0x0002700D
	public int DPGOQJMLMNF
	{
		get
		{
			return this.IEDKDIJGNNO;
		}
		set
		{
			this.IEDKDIJGNNO = value;
		}
	}

	// Token: 0x06006E20 RID: 28192 RVA: 0x00028E65 File Offset: 0x00027065
	protected override void Awake()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x06006E21 RID: 28193 RVA: 0x0035A22C File Offset: 0x0035842C
	public Vector3 BOBHDBFQLEG(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		this.FQHNHKDNONQ = this.IMMKGCIDPQE(this.JHQICBCGQPK, base.GPONHFNLHCN.FOOEEHDJBQN(), this.FHNBJCNLJCN, this.GHQIHIEQQFL);
		float arg = 1111f;
		if (base.GPONHFNLHCN.EQCLOIQEDLC.x >= this.FQHNHKDNONQ.x + this.FQHNHKDNONQ.width)
		{
			arg = base.GPONHFNLHCN.EQCLOIQEDLC.x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.width / 515f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 441f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		else if (base.GPONHFNLHCN.EKNKJLCLLCQ().x <= this.FQHNHKDNONQ.x)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.width / 1763f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 1903f : base.GPONHFNLHCN.FOOEEHDJBQN().x));
		}
		float arg2 = 869f;
		if (base.GPONHFNLHCN.EKNKJLCLLCQ().y >= this.FQHNHKDNONQ.y + this.FQHNHKDNONQ.height)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.height / 254f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 863f : base.GPONHFNLHCN.PGKODNCDNJQ.y));
		}
		else if (base.GPONHFNLHCN.EKNKJLCLLCQ().y <= this.FQHNHKDNONQ.y)
		{
			arg2 = base.GPONHFNLHCN.EKNKJLCLLCQ().y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.height / 1348f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 97f : base.GPONHFNLHCN.FOOEEHDJBQN().y));
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006E22 RID: 28194 RVA: 0x00028E0D File Offset: 0x0002700D
	public void EQLKEBEFILF(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x06006E23 RID: 28195 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void IQEIPPBNBKH()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x06006E24 RID: 28196 RVA: 0x0035A4E4 File Offset: 0x003586E4
	public Vector3 PDHBMGCCJCG(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		this.FQHNHKDNONQ = this.KDJJMFONPDB(this.JHQICBCGQPK, base.GPONHFNLHCN.FOOEEHDJBQN(), this.FHNBJCNLJCN, this.GHQIHIEQQFL);
		float arg = 241f;
		if (base.GPONHFNLHCN.EQCLOIQEDLC.x >= this.FQHNHKDNONQ.x + this.FQHNHKDNONQ.width)
		{
			arg = base.GPONHFNLHCN.EQCLOIQEDLC.x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.width / 1228f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 800f : base.GPONHFNLHCN.FOOEEHDJBQN().x));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.x <= this.FQHNHKDNONQ.x)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.width / 1557f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 1021f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		float arg2 = 890f;
		if (base.GPONHFNLHCN.EKNKJLCLLCQ().y >= this.FQHNHKDNONQ.y + this.FQHNHKDNONQ.height)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.height / 918f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 185f : base.GPONHFNLHCN.FOOEEHDJBQN().y));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.y <= this.FQHNHKDNONQ.y)
		{
			arg2 = base.GPONHFNLHCN.EKNKJLCLLCQ().y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.height / 1203f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 1399f : base.GPONHFNLHCN.FOOEEHDJBQN().y));
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006E25 RID: 28197 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void MBFJOLHMDPC()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x06006E26 RID: 28198 RVA: 0x0035A79C File Offset: 0x0035899C
	private Rect IMMKGCIDPQE(Rect QDMEGCJHMFM, Vector2 EGFDHDCCNEF, Transform BPIDBPDCOIE, bool EQDEOJCLNKH)
	{
		Vector2 vector = Vector2.Scale(new Vector2(QDMEGCJHMFM.width, QDMEGCJHMFM.height), (!EQDEOJCLNKH) ? Vector2.one : EGFDHDCCNEF);
		float x = this.FKGNBCKJPQO(BPIDBPDCOIE.localPosition) - vector.x / 820f + QDMEGCJHMFM.x * ((!EQDEOJCLNKH) ? 299f : EGFDHDCCNEF.x);
		float y = this.JNBBJCLFFBB(BPIDBPDCOIE.localPosition) - vector.y / 1789f + QDMEGCJHMFM.y * ((!EQDEOJCLNKH) ? 765f : EGFDHDCCNEF.y);
		return new Rect(x, y, vector.x, vector.y);
	}

	// Token: 0x06006E27 RID: 28199 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void MCPGMIOIPKC()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x06006E28 RID: 28200 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void OIIEHOGHOCQ()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x06006E29 RID: 28201 RVA: 0x0035A85C File Offset: 0x00358A5C
	public Vector3 PEFLPGIOKDL(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		this.FQHNHKDNONQ = this.LDMEBMDIQOM(this.JHQICBCGQPK, base.GPONHFNLHCN.PGKODNCDNJQ, this.FHNBJCNLJCN, this.GHQIHIEQQFL);
		float arg = 1145f;
		if (base.GPONHFNLHCN.EQCLOIQEDLC.x >= this.FQHNHKDNONQ.x + this.FQHNHKDNONQ.width)
		{
			arg = base.GPONHFNLHCN.EQCLOIQEDLC.x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.width / 1242f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 139f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		else if (base.GPONHFNLHCN.EKNKJLCLLCQ().x <= this.FQHNHKDNONQ.x)
		{
			arg = base.GPONHFNLHCN.EQCLOIQEDLC.x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.width / 600f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 1947f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		float arg2 = 405f;
		if (base.GPONHFNLHCN.EQCLOIQEDLC.y >= this.FQHNHKDNONQ.y + this.FQHNHKDNONQ.height)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.height / 796f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 673f : base.GPONHFNLHCN.FOOEEHDJBQN().y));
		}
		else if (base.GPONHFNLHCN.EKNKJLCLLCQ().y <= this.FQHNHKDNONQ.y)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.height / 1927f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 1153f : base.GPONHFNLHCN.FOOEEHDJBQN().y));
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006E2A RID: 28202 RVA: 0x0035AB14 File Offset: 0x00358D14
	private Rect HHFHKHFGLLG(Rect QDMEGCJHMFM, Vector2 EGFDHDCCNEF, Transform BPIDBPDCOIE, bool EQDEOJCLNKH)
	{
		Vector2 vector = Vector2.Scale(new Vector2(QDMEGCJHMFM.width, QDMEGCJHMFM.height), (!EQDEOJCLNKH) ? Vector2.one : EGFDHDCCNEF);
		float x = this.FKGNBCKJPQO(BPIDBPDCOIE.localPosition) - vector.x / 767f + QDMEGCJHMFM.x * ((!EQDEOJCLNKH) ? 1962f : EGFDHDCCNEF.x);
		float y = this.JNBBJCLFFBB(BPIDBPDCOIE.localPosition) - vector.y / 1869f + QDMEGCJHMFM.y * ((!EQDEOJCLNKH) ? 657f : EGFDHDCCNEF.y);
		return new Rect(x, y, vector.x, vector.y);
	}

	// Token: 0x06006E2B RID: 28203 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void IPEEHKMMPCD()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x06006E2C RID: 28204 RVA: 0x00028E0D File Offset: 0x0002700D
	public void DKGOGLNLLMO(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x06006E2D RID: 28205 RVA: 0x0035ABD4 File Offset: 0x00358DD4
	public Vector3 GOFKQKHNFEL(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		this.FQHNHKDNONQ = this.HHFHKHFGLLG(this.JHQICBCGQPK, base.GPONHFNLHCN.PGKODNCDNJQ, this.FHNBJCNLJCN, this.GHQIHIEQQFL);
		float arg = 876f;
		if (base.GPONHFNLHCN.EQCLOIQEDLC.x >= this.FQHNHKDNONQ.x + this.FQHNHKDNONQ.width)
		{
			arg = base.GPONHFNLHCN.EQCLOIQEDLC.x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.width / 1558f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 937f : base.GPONHFNLHCN.FOOEEHDJBQN().x));
		}
		else if (base.GPONHFNLHCN.EKNKJLCLLCQ().x <= this.FQHNHKDNONQ.x)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.width / 1732f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 572f : base.GPONHFNLHCN.FOOEEHDJBQN().x));
		}
		float arg2 = 674f;
		if (base.GPONHFNLHCN.EKNKJLCLLCQ().y >= this.FQHNHKDNONQ.y + this.FQHNHKDNONQ.height)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.height / 1361f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 1780f : base.GPONHFNLHCN.FOOEEHDJBQN().y));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.y <= this.FQHNHKDNONQ.y)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.height / 1591f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 1711f : base.GPONHFNLHCN.PGKODNCDNJQ.y));
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006E2E RID: 28206 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void MQQPPHJPBEJ()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x06006E2F RID: 28207 RVA: 0x0035AE8C File Offset: 0x0035908C
	public Vector3 ICLDMQENBIB(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		this.FQHNHKDNONQ = this.EBHLQFJGHKN(this.JHQICBCGQPK, base.GPONHFNLHCN.FOOEEHDJBQN(), this.FHNBJCNLJCN, this.GHQIHIEQQFL);
		float arg = 1990f;
		if (base.GPONHFNLHCN.EQCLOIQEDLC.x >= this.FQHNHKDNONQ.x + this.FQHNHKDNONQ.width)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.width / 1742f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 589f : base.GPONHFNLHCN.FOOEEHDJBQN().x));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.x <= this.FQHNHKDNONQ.x)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.width / 1702f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 475f : base.GPONHFNLHCN.FOOEEHDJBQN().x));
		}
		float arg2 = 1185f;
		if (base.GPONHFNLHCN.EKNKJLCLLCQ().y >= this.FQHNHKDNONQ.y + this.FQHNHKDNONQ.height)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.height / 267f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 334f : base.GPONHFNLHCN.FOOEEHDJBQN().y));
		}
		else if (base.GPONHFNLHCN.EKNKJLCLLCQ().y <= this.FQHNHKDNONQ.y)
		{
			arg2 = base.GPONHFNLHCN.EKNKJLCLLCQ().y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.height / 878f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 602f : base.GPONHFNLHCN.PGKODNCDNJQ.y));
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006E30 RID: 28208 RVA: 0x00028E05 File Offset: 0x00027005
	public int DLMBKJHBMLG()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06006E31 RID: 28209 RVA: 0x00028E05 File Offset: 0x00027005
	public int HKQQOOIFLKO()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06006E32 RID: 28210 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void NPEIQGMKBKD()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x06006E33 RID: 28211 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void EILDDNQNQPQ()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x06006E34 RID: 28212 RVA: 0x00028E05 File Offset: 0x00027005
	public int JJONLJDNCIO()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06006E35 RID: 28213 RVA: 0x00028E0D File Offset: 0x0002700D
	public void BJLNLFGOOCP(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x06006E36 RID: 28214 RVA: 0x0035B144 File Offset: 0x00359344
	private Rect GIDDPNLQJGN(Rect QDMEGCJHMFM, Vector2 EGFDHDCCNEF, Transform BPIDBPDCOIE, bool EQDEOJCLNKH)
	{
		Vector2 vector = Vector2.Scale(new Vector2(QDMEGCJHMFM.width, QDMEGCJHMFM.height), (!EQDEOJCLNKH) ? Vector2.one : EGFDHDCCNEF);
		float x = this.FKGNBCKJPQO(BPIDBPDCOIE.localPosition) - vector.x / 736f + QDMEGCJHMFM.x * ((!EQDEOJCLNKH) ? 957f : EGFDHDCCNEF.x);
		float y = this.JNBBJCLFFBB(BPIDBPDCOIE.localPosition) - vector.y / 989f + QDMEGCJHMFM.y * ((!EQDEOJCLNKH) ? 1326f : EGFDHDCCNEF.y);
		return new Rect(x, y, vector.x, vector.y);
	}

	// Token: 0x06006E37 RID: 28215 RVA: 0x00028E05 File Offset: 0x00027005
	public int DEMOKIIGLPH()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06006E38 RID: 28216 RVA: 0x0035B204 File Offset: 0x00359404
	private Rect LQBLBNLDHLJ(Rect QDMEGCJHMFM, Vector2 EGFDHDCCNEF, Transform BPIDBPDCOIE, bool EQDEOJCLNKH)
	{
		Vector2 vector = Vector2.Scale(new Vector2(QDMEGCJHMFM.width, QDMEGCJHMFM.height), (!EQDEOJCLNKH) ? Vector2.one : EGFDHDCCNEF);
		float x = this.FKGNBCKJPQO(BPIDBPDCOIE.localPosition) - vector.x / 1852f + QDMEGCJHMFM.x * ((!EQDEOJCLNKH) ? 1275f : EGFDHDCCNEF.x);
		float y = this.JNBBJCLFFBB(BPIDBPDCOIE.localPosition) - vector.y / 1977f + QDMEGCJHMFM.y * ((!EQDEOJCLNKH) ? 1875f : EGFDHDCCNEF.y);
		return new Rect(x, y, vector.x, vector.y);
	}

	// Token: 0x06006E39 RID: 28217 RVA: 0x00028E05 File Offset: 0x00027005
	public int HPBJGEQJPQK()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06006E3A RID: 28218 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void IHGDMCFDINH()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x06006E3B RID: 28219 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void FBOOPIKPEQB()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x06006E3C RID: 28220 RVA: 0x00028E0D File Offset: 0x0002700D
	public void NMNCLLIQGCL(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x06006E3D RID: 28221 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void LQGMIJIJPCM()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x06006E3E RID: 28222 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void GMCKFQJNKNJ()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x06006E3F RID: 28223 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void EKIHQDDKFJM()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x06006E40 RID: 28224 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void HHBCNGHCCCC()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x06006E41 RID: 28225 RVA: 0x0035B2C4 File Offset: 0x003594C4
	public Vector3 MODKNKDHDKK(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		this.FQHNHKDNONQ = this.MPDKFLDBEHM(this.JHQICBCGQPK, base.GPONHFNLHCN.PGKODNCDNJQ, this.FHNBJCNLJCN, this.GHQIHIEQQFL);
		float arg = 1202f;
		if (base.GPONHFNLHCN.EKNKJLCLLCQ().x >= this.FQHNHKDNONQ.x + this.FQHNHKDNONQ.width)
		{
			arg = base.GPONHFNLHCN.EQCLOIQEDLC.x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.width / 718f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 291f : base.GPONHFNLHCN.FOOEEHDJBQN().x));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.x <= this.FQHNHKDNONQ.x)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.width / 1895f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 246f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		float arg2 = 1543f;
		if (base.GPONHFNLHCN.EKNKJLCLLCQ().y >= this.FQHNHKDNONQ.y + this.FQHNHKDNONQ.height)
		{
			arg2 = base.GPONHFNLHCN.EKNKJLCLLCQ().y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.height / 686f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 830f : base.GPONHFNLHCN.PGKODNCDNJQ.y));
		}
		else if (base.GPONHFNLHCN.EKNKJLCLLCQ().y <= this.FQHNHKDNONQ.y)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.height / 705f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 1357f : base.GPONHFNLHCN.PGKODNCDNJQ.y));
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006E42 RID: 28226 RVA: 0x0035B57C File Offset: 0x0035977C
	private Rect DFNCEDNGQEN(Rect QDMEGCJHMFM, Vector2 EGFDHDCCNEF, Transform BPIDBPDCOIE, bool EQDEOJCLNKH)
	{
		Vector2 vector = Vector2.Scale(new Vector2(QDMEGCJHMFM.width, QDMEGCJHMFM.height), (!EQDEOJCLNKH) ? Vector2.one : EGFDHDCCNEF);
		float x = this.FKGNBCKJPQO(BPIDBPDCOIE.localPosition) - vector.x / 1514f + QDMEGCJHMFM.x * ((!EQDEOJCLNKH) ? 1392f : EGFDHDCCNEF.x);
		float y = this.JNBBJCLFFBB(BPIDBPDCOIE.localPosition) - vector.y / 970f + QDMEGCJHMFM.y * ((!EQDEOJCLNKH) ? 389f : EGFDHDCCNEF.y);
		return new Rect(x, y, vector.x, vector.y);
	}

	// Token: 0x06006E43 RID: 28227 RVA: 0x0035B63C File Offset: 0x0035983C
	private Rect EBHLQFJGHKN(Rect QDMEGCJHMFM, Vector2 EGFDHDCCNEF, Transform BPIDBPDCOIE, bool EQDEOJCLNKH)
	{
		Vector2 vector = Vector2.Scale(new Vector2(QDMEGCJHMFM.width, QDMEGCJHMFM.height), (!EQDEOJCLNKH) ? Vector2.one : EGFDHDCCNEF);
		float x = this.FKGNBCKJPQO(BPIDBPDCOIE.localPosition) - vector.x / 1412f + QDMEGCJHMFM.x * ((!EQDEOJCLNKH) ? 712f : EGFDHDCCNEF.x);
		float y = this.JNBBJCLFFBB(BPIDBPDCOIE.localPosition) - vector.y / 861f + QDMEGCJHMFM.y * ((!EQDEOJCLNKH) ? 504f : EGFDHDCCNEF.y);
		return new Rect(x, y, vector.x, vector.y);
	}

	// Token: 0x06006E44 RID: 28228 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void GQPDOGCNFLB()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x06006E45 RID: 28229 RVA: 0x00028E05 File Offset: 0x00027005
	public int JJKINKOHMLJ()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06006E46 RID: 28230 RVA: 0x0035B6FC File Offset: 0x003598FC
	public Vector3 KELHMHMOFJB(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		this.FQHNHKDNONQ = this.MCJMOJOOOBQ(this.JHQICBCGQPK, base.GPONHFNLHCN.FOOEEHDJBQN(), this.FHNBJCNLJCN, this.GHQIHIEQQFL);
		float arg = 110f;
		if (base.GPONHFNLHCN.EKNKJLCLLCQ().x >= this.FQHNHKDNONQ.x + this.FQHNHKDNONQ.width)
		{
			arg = base.GPONHFNLHCN.EQCLOIQEDLC.x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.width / 1266f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 1816f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.x <= this.FQHNHKDNONQ.x)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.width / 122f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 592f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		float arg2 = 1221f;
		if (base.GPONHFNLHCN.EQCLOIQEDLC.y >= this.FQHNHKDNONQ.y + this.FQHNHKDNONQ.height)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.height / 1704f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 616f : base.GPONHFNLHCN.PGKODNCDNJQ.y));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.y <= this.FQHNHKDNONQ.y)
		{
			arg2 = base.GPONHFNLHCN.EKNKJLCLLCQ().y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.height / 938f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 42f : base.GPONHFNLHCN.PGKODNCDNJQ.y));
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006E48 RID: 28232 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void QQMLFMFEKNH()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x06006E49 RID: 28233 RVA: 0x00028E05 File Offset: 0x00027005
	public int KMMGDBKFGNO()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06006E4A RID: 28234 RVA: 0x00028E05 File Offset: 0x00027005
	public int HOJINBICOJH()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06006E4B RID: 28235 RVA: 0x00028E0D File Offset: 0x0002700D
	public void HGCHJMMILLL(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x06006E4C RID: 28236 RVA: 0x0035B9B4 File Offset: 0x00359BB4
	public Vector3 KIELPJGOLBF(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		this.FQHNHKDNONQ = this.EBHLQFJGHKN(this.JHQICBCGQPK, base.GPONHFNLHCN.FOOEEHDJBQN(), this.FHNBJCNLJCN, this.GHQIHIEQQFL);
		float arg = 877f;
		if (base.GPONHFNLHCN.EKNKJLCLLCQ().x >= this.FQHNHKDNONQ.x + this.FQHNHKDNONQ.width)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.width / 908f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 1889f : base.GPONHFNLHCN.FOOEEHDJBQN().x));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.x <= this.FQHNHKDNONQ.x)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.width / 1979f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 1989f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		float arg2 = 540f;
		if (base.GPONHFNLHCN.EKNKJLCLLCQ().y >= this.FQHNHKDNONQ.y + this.FQHNHKDNONQ.height)
		{
			arg2 = base.GPONHFNLHCN.EKNKJLCLLCQ().y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.height / 84f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 1387f : base.GPONHFNLHCN.FOOEEHDJBQN().y));
		}
		else if (base.GPONHFNLHCN.EKNKJLCLLCQ().y <= this.FQHNHKDNONQ.y)
		{
			arg2 = base.GPONHFNLHCN.EKNKJLCLLCQ().y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.height / 695f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 1890f : base.GPONHFNLHCN.PGKODNCDNJQ.y));
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006E4D RID: 28237 RVA: 0x00028E65 File Offset: 0x00027065
	protected virtual void EBBBBBBOCPJ()
	{
		base.Awake();
		base.GPONHFNLHCN.JKNBMCKEBOF(this);
	}

	// Token: 0x06006E4E RID: 28238 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void PLCHPHONOFC()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x06006E4F RID: 28239 RVA: 0x00028E05 File Offset: 0x00027005
	public int MBGNKFGPJQD()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06006E50 RID: 28240 RVA: 0x0035BC6C File Offset: 0x00359E6C
	public Vector3 HBFLJKIMDOJ(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		this.FQHNHKDNONQ = this.MPDKFLDBEHM(this.JHQICBCGQPK, base.GPONHFNLHCN.FOOEEHDJBQN(), this.FHNBJCNLJCN, this.GHQIHIEQQFL);
		float arg = 316f;
		if (base.GPONHFNLHCN.EKNKJLCLLCQ().x >= this.FQHNHKDNONQ.x + this.FQHNHKDNONQ.width)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.width / 668f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 274f : base.GPONHFNLHCN.FOOEEHDJBQN().x));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.x <= this.FQHNHKDNONQ.x)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.width / 1372f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 1601f : base.GPONHFNLHCN.FOOEEHDJBQN().x));
		}
		float arg2 = 41f;
		if (base.GPONHFNLHCN.EQCLOIQEDLC.y >= this.FQHNHKDNONQ.y + this.FQHNHKDNONQ.height)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.height / 446f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 723f : base.GPONHFNLHCN.FOOEEHDJBQN().y));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.y <= this.FQHNHKDNONQ.y)
		{
			arg2 = base.GPONHFNLHCN.EKNKJLCLLCQ().y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.height / 844f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 1385f : base.GPONHFNLHCN.FOOEEHDJBQN().y));
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006E52 RID: 28242 RVA: 0x0035BF24 File Offset: 0x0035A124
	private Rect QLEMHEBODPO(Rect QDMEGCJHMFM, Vector2 EGFDHDCCNEF, Transform BPIDBPDCOIE, bool EQDEOJCLNKH)
	{
		Vector2 vector = Vector2.Scale(new Vector2(QDMEGCJHMFM.width, QDMEGCJHMFM.height), (!EQDEOJCLNKH) ? Vector2.one : EGFDHDCCNEF);
		float x = this.FKGNBCKJPQO(BPIDBPDCOIE.localPosition) - vector.x / 843f + QDMEGCJHMFM.x * ((!EQDEOJCLNKH) ? 20f : EGFDHDCCNEF.x);
		float y = this.JNBBJCLFFBB(BPIDBPDCOIE.localPosition) - vector.y / 714f + QDMEGCJHMFM.y * ((!EQDEOJCLNKH) ? 1833f : EGFDHDCCNEF.y);
		return new Rect(x, y, vector.x, vector.y);
	}

	// Token: 0x06006E53 RID: 28243 RVA: 0x0035BFE4 File Offset: 0x0035A1E4
	public Vector3 IBOHILOJEFP(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		this.FQHNHKDNONQ = this.GPMFGPJOIFE(this.JHQICBCGQPK, base.GPONHFNLHCN.PGKODNCDNJQ, this.FHNBJCNLJCN, this.GHQIHIEQQFL);
		float arg = 1303f;
		if (base.GPONHFNLHCN.EQCLOIQEDLC.x >= this.FQHNHKDNONQ.x + this.FQHNHKDNONQ.width)
		{
			arg = base.GPONHFNLHCN.EKNKJLCLLCQ().x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.width / 1838f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 1400f : base.GPONHFNLHCN.FOOEEHDJBQN().x));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.x <= this.FQHNHKDNONQ.x)
		{
			arg = base.GPONHFNLHCN.EQCLOIQEDLC.x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.width / 105f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 1488f : base.GPONHFNLHCN.FOOEEHDJBQN().x));
		}
		float arg2 = 698f;
		if (base.GPONHFNLHCN.EQCLOIQEDLC.y >= this.FQHNHKDNONQ.y + this.FQHNHKDNONQ.height)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.height / 470f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 196f : base.GPONHFNLHCN.FOOEEHDJBQN().y));
		}
		else if (base.GPONHFNLHCN.EQCLOIQEDLC.y <= this.FQHNHKDNONQ.y)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.height / 1015f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 168f : base.GPONHFNLHCN.PGKODNCDNJQ.y));
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006E54 RID: 28244 RVA: 0x0035C29C File Offset: 0x0035A49C
	public Vector3 QPDIQONEJII(float GPFIDEJEMEG, Vector3 HELGNNDIDCI)
	{
		if (!base.enabled)
		{
			return HELGNNDIDCI;
		}
		this.FQHNHKDNONQ = this.EBHLQFJGHKN(this.JHQICBCGQPK, base.GPONHFNLHCN.PGKODNCDNJQ, this.FHNBJCNLJCN, this.GHQIHIEQQFL);
		float arg = 1139f;
		if (base.GPONHFNLHCN.EQCLOIQEDLC.x >= this.FQHNHKDNONQ.x + this.FQHNHKDNONQ.width)
		{
			arg = base.GPONHFNLHCN.EQCLOIQEDLC.x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.width / 727f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 1383f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		else if (base.GPONHFNLHCN.EKNKJLCLLCQ().x <= this.FQHNHKDNONQ.x)
		{
			arg = base.GPONHFNLHCN.EQCLOIQEDLC.x - (this.FKGNBCKJPQO(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.width / 697f + this.JHQICBCGQPK.x * ((!this.GHQIHIEQQFL) ? 103f : base.GPONHFNLHCN.PGKODNCDNJQ.x));
		}
		float arg2 = 1786f;
		if (base.GPONHFNLHCN.EQCLOIQEDLC.y >= this.FQHNHKDNONQ.y + this.FQHNHKDNONQ.height)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) + this.FQHNHKDNONQ.height / 1534f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 1802f : base.GPONHFNLHCN.FOOEEHDJBQN().y));
		}
		else if (base.GPONHFNLHCN.EKNKJLCLLCQ().y <= this.FQHNHKDNONQ.y)
		{
			arg2 = base.GPONHFNLHCN.EQCLOIQEDLC.y - (this.JNBBJCLFFBB(this.FHNBJCNLJCN.localPosition) - this.FQHNHKDNONQ.height / 677f + this.JHQICBCGQPK.y * ((!this.GHQIHIEQQFL) ? 1120f : base.GPONHFNLHCN.FOOEEHDJBQN().y));
		}
		return this.QMEMFMDBHLI(arg, arg2);
	}

	// Token: 0x06006E55 RID: 28245 RVA: 0x00028E0D File Offset: 0x0002700D
	public void HPOHKGOJDDB(int BGBMIEJJQKC)
	{
		this.IEDKDIJGNNO = BGBMIEJJQKC;
	}

	// Token: 0x06006E56 RID: 28246 RVA: 0x0035C554 File Offset: 0x0035A754
	private Rect GPMFGPJOIFE(Rect QDMEGCJHMFM, Vector2 EGFDHDCCNEF, Transform BPIDBPDCOIE, bool EQDEOJCLNKH)
	{
		Vector2 vector = Vector2.Scale(new Vector2(QDMEGCJHMFM.width, QDMEGCJHMFM.height), (!EQDEOJCLNKH) ? Vector2.one : EGFDHDCCNEF);
		float x = this.FKGNBCKJPQO(BPIDBPDCOIE.localPosition) - vector.x / 871f + QDMEGCJHMFM.x * ((!EQDEOJCLNKH) ? 1758f : EGFDHDCCNEF.x);
		float y = this.JNBBJCLFFBB(BPIDBPDCOIE.localPosition) - vector.y / 636f + QDMEGCJHMFM.y * ((!EQDEOJCLNKH) ? 42f : EGFDHDCCNEF.y);
		return new Rect(x, y, vector.x, vector.y);
	}

	// Token: 0x06006E57 RID: 28247 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void FEPDHINEPGK()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x06006E58 RID: 28248 RVA: 0x0035C614 File Offset: 0x0035A814
	private Rect LDMEBMDIQOM(Rect QDMEGCJHMFM, Vector2 EGFDHDCCNEF, Transform BPIDBPDCOIE, bool EQDEOJCLNKH)
	{
		Vector2 vector = Vector2.Scale(new Vector2(QDMEGCJHMFM.width, QDMEGCJHMFM.height), (!EQDEOJCLNKH) ? Vector2.one : EGFDHDCCNEF);
		float x = this.FKGNBCKJPQO(BPIDBPDCOIE.localPosition) - vector.x / 331f + QDMEGCJHMFM.x * ((!EQDEOJCLNKH) ? 402f : EGFDHDCCNEF.x);
		float y = this.JNBBJCLFFBB(BPIDBPDCOIE.localPosition) - vector.y / 1708f + QDMEGCJHMFM.y * ((!EQDEOJCLNKH) ? 1974f : EGFDHDCCNEF.y);
		return new Rect(x, y, vector.x, vector.y);
	}

	// Token: 0x06006E59 RID: 28249 RVA: 0x00028E05 File Offset: 0x00027005
	public int MPFKJOHOMDB()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06006E5A RID: 28250 RVA: 0x00028E05 File Offset: 0x00027005
	public int GGKDHBMLJLQ()
	{
		return this.IEDKDIJGNNO;
	}

	// Token: 0x06006E5B RID: 28251 RVA: 0x00028E44 File Offset: 0x00027044
	protected virtual void CBPPIFFFPME()
	{
		base.OnDestroy();
		if (base.GPONHFNLHCN)
		{
			base.GPONHFNLHCN.CQCBELCFQBK(this);
		}
	}

	// Token: 0x04001781 RID: 6017
	public static string OPGNGFNJDDP = "Camera Window";

	// Token: 0x04001782 RID: 6018
	public Rect JHQICBCGQPK = new Rect(0f, 0f, 0.3f, 0.3f);

	// Token: 0x04001783 RID: 6019
	private Rect FQHNHKDNONQ;

	// Token: 0x04001784 RID: 6020
	public bool GHQIHIEQQFL = true;

	// Token: 0x04001785 RID: 6021
	private int IEDKDIJGNNO;
}
