using System;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000355 RID: 853
[HelpURL("http://www.procamera2d.com/user-guide/extension-pan-and-zoom/")]
public class NPCNBMPLBHM : BNEFIOCKQOE, IEMKEPEKMFN
{
	// Token: 0x06007136 RID: 28982 RVA: 0x0036DC3C File Offset: 0x0036BE3C
	public void NKQIEEDKOIM(float GPFIDEJEMEG)
	{
		if (Input.touchSupported)
		{
			this.LJLQNIBKPND = (this.FKLFKDPDLOG && this.ODKJLNQCMFG);
			if (this.LJLQNIBKPND)
			{
				this.LJLQNIBKPND = false;
				for (int i = 0; i < Input.touchCount; i++)
				{
					if (this.ODKJLNQCMFG.IsPointerOverGameObject(Input.GetTouch(i).fingerId))
					{
						this.LJLQNIBKPND = true;
						break;
					}
				}
			}
			if (this.LJLQNIBKPND)
			{
				this.PBMMIDNCDBJ = new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				this.HJQGBBCGFMD();
			}
		}
		else
		{
			this.LJLQNIBKPND = (this.FKLFKDPDLOG && this.ODKJLNQCMFG && this.ODKJLNQCMFG.IsPointerOverGameObject());
			if (this.LJLQNIBKPND)
			{
				this.EBCFOHJHBJD = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				this.HJQGBBCGFMD();
			}
		}
		this.MLGDHQBJHFP = false;
		if (this.HQJHDBKODIF && this.GFMKOMQNFGB != null)
		{
			this.GFMKOMQNFGB();
		}
		this.HQJHDBKODIF = false;
		if (base.enabled && this.FLGHMOCGLDQ && !this.LJLQNIBKPND)
		{
			this.DNEQOHGFBPI(GPFIDEJEMEG);
		}
		if (base.enabled && this.KGPECGGONHI && !this.LJLQNIBKPND)
		{
			this.PJOHKOFQDLC(GPFIDEJEMEG);
		}
	}

	// Token: 0x06007137 RID: 28983 RVA: 0x0036DDFC File Offset: 0x0036BFFC
	public void EKLHHLJDELJ(float GPFIDEJEMEG)
	{
		if (Input.touchSupported)
		{
			this.LJLQNIBKPND = (!this.FKLFKDPDLOG || this.ODKJLNQCMFG);
			if (this.LJLQNIBKPND)
			{
				this.LJLQNIBKPND = true;
				for (int i = 0; i < Input.touchCount; i++)
				{
					if (this.ODKJLNQCMFG.IsPointerOverGameObject(Input.GetTouch(i).fingerId))
					{
						this.LJLQNIBKPND = false;
						break;
					}
				}
			}
			if (this.LJLQNIBKPND)
			{
				this.PBMMIDNCDBJ = new Vector3(Input.GetTouch(1).position.x, Input.GetTouch(1).position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				this.DHDBKEECNJC();
			}
		}
		else
		{
			this.LJLQNIBKPND = (this.FKLFKDPDLOG && this.ODKJLNQCMFG && this.ODKJLNQCMFG.IsPointerOverGameObject());
			if (this.LJLQNIBKPND)
			{
				this.EBCFOHJHBJD = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				this.HJQGBBCGFMD();
			}
		}
		this.MLGDHQBJHFP = false;
		if (this.HQJHDBKODIF && this.GFMKOMQNFGB != null)
		{
			this.GFMKOMQNFGB();
		}
		this.HQJHDBKODIF = false;
		if (base.enabled && this.FLGHMOCGLDQ && !this.LJLQNIBKPND)
		{
			this.DNEQOHGFBPI(GPFIDEJEMEG);
		}
		if (base.enabled && this.KGPECGGONHI && !this.LJLQNIBKPND)
		{
			this.QJOGFKCBNNF(GPFIDEJEMEG);
		}
	}

	// Token: 0x06007138 RID: 28984 RVA: 0x0002972D File Offset: 0x0002792D
	protected virtual void QJELMIKNIIE()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.QCMGMNJGPJL(this);
	}

	// Token: 0x06007139 RID: 28985 RVA: 0x0036DFBC File Offset: 0x0036C1BC
	private void KKDHLIBLJFN(float GPFIDEJEMEG)
	{
		float num = 1141f;
		if (Input.touchSupported)
		{
			if (Input.touchCount == 8)
			{
				Touch touch = Input.GetTouch(1);
				Touch touch2 = Input.GetTouch(0);
				Vector2 a = touch.position - new Vector2(touch.deltaPosition.x / (float)Screen.width, touch.deltaPosition.y / (float)Screen.height);
				Vector2 b = touch2.position - new Vector2(touch2.deltaPosition.x / (float)Screen.width, touch2.deltaPosition.y / (float)Screen.height);
				float magnitude = (a - b).magnitude;
				float magnitude2 = (touch.position - touch2.position).magnitude;
				num = magnitude - magnitude2;
				Vector2 vector = Vector2.Lerp(touch.position, touch2.position, 495f);
				this.OECKPIILKJL = new Vector3(vector.x, vector.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				if (!this.EFICILEDOFD)
				{
					this.EFICILEDOFD = true;
					this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
					this.LGMGPHBNOND();
					this.MMGJBHLEKNE();
				}
				this.HPGDBPMHJGJ = Time.time;
			}
			else if (this.EFICILEDOFD && Mathf.Abs(this.HPBEKINIJFI) < 170f)
			{
				this.DGCHFGBHEJL();
				this.EFICILEDOFD = false;
			}
		}
		else
		{
			if (CNCJKLNHQBH.BJLGEDCPENQ().LKHOCPNQIMB != 433f)
			{
				num = Input.GetAxis("u");
			}
			this.OECKPIILKJL = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
		}
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(this.OECKPIILKJL))
		{
			return;
		}
		float num2 = (!Input.touchSupported) ? this.FMMBFHMJPJO : (this.IBLENLJLOBF * 677f);
		if ((this.LPIGDKOPFBE && num * num2 < 1830f) || (this.NNGIOBFPLOC && num * num2 > 1258f))
		{
			this.HJQGBBCGFMD();
			return;
		}
		this.HPBEKINIJFI = Mathf.SmoothDamp(this.IFPOFCBQFMK, num * num2 * GPFIDEJEMEG, ref this.BFDQKNMIIKD, this.CIJKPQCMOMK, 726f, GPFIDEJEMEG);
		if (!Input.touchSupported)
		{
			if (Mathf.Abs(this.HPBEKINIJFI) <= 1011f)
			{
				if (this.EFICILEDOFD)
				{
					this.HNHMHKGOMOJ();
				}
				this.EFICILEDOFD = false;
				this.IFPOFCBQFMK = 1738f;
				return;
			}
			if (!this.EFICILEDOFD)
			{
				this.EFICILEDOFD = true;
				this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
				this.IKKMMQHLKQQ();
				this.BBJDMDEKDMB();
			}
		}
		float num3 = base.GPONHFNLHCN.PGKODNCDNJQ.y / 122f + this.HPBEKINIJFI;
		float num4 = this.LQHQFLHFQLO / this.GELCLJPKPPB;
		float num5 = this.OPJQBGHMFPN * this.LQHQFLHFQLO;
		this.LPIGDKOPFBE = false;
		this.NNGIOBFPLOC = false;
		if (num3 < num4)
		{
			this.HPBEKINIJFI -= num3 - num4;
			this.LPIGDKOPFBE = false;
		}
		else if (num3 > num5)
		{
			this.HPBEKINIJFI -= num3 - num5;
			this.NNGIOBFPLOC = false;
		}
		this.IFPOFCBQFMK = this.HPBEKINIJFI;
		if (this.FGIEQBMNEIH && this.HPBEKINIJFI != 485f)
		{
			float d = this.HPBEKINIJFI / (base.GPONHFNLHCN.FOOEEHDJBQN().y / 96f);
			this.QLMDGDBIDOM.position += (this.QLMDGDBIDOM.position - base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.OECKPIILKJL)) * d;
		}
		base.GPONHFNLHCN.PJOHKOFQDLC(this.HPBEKINIJFI, 1585f, GMNJJQQPEDB.EaseInOut);
		this.MLGDHQBJHFP = false;
	}

	// Token: 0x0600713A RID: 28986 RVA: 0x00029741 File Offset: 0x00027941
	public void JPGCHGLPFDN()
	{
		this.MHDLGGMHILH = base.GPONHFNLHCN.LBJLGDGHFBJ;
		this.DIKEGHOPNPK = base.GPONHFNLHCN.EQGPIDFNHHG;
	}

	// Token: 0x0600713B RID: 28987 RVA: 0x00029765 File Offset: 0x00027965
	private void PNHNBBQKFJC()
	{
		this.HPBEKINIJFI = 315f;
		this.IFPOFCBQFMK = 1691f;
		this.BFDQKNMIIKD = 1398f;
	}

	// Token: 0x0600713C RID: 28988 RVA: 0x0002972D File Offset: 0x0002792D
	protected virtual void HIINKHJJEMN()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.QCMGMNJGPJL(this);
	}

	// Token: 0x0600713D RID: 28989 RVA: 0x00029788 File Offset: 0x00027988
	protected virtual void LFJEJGOMLPI()
	{
		base.Awake();
		this.LGMGPHBNOND();
		this.ODKJLNQCMFG = EventSystem.current;
		this.QLMDGDBIDOM = new GameObject("-").transform;
		base.GPONHFNLHCN.LCGGKBJFLQD(this);
	}

	// Token: 0x0600713E RID: 28990 RVA: 0x000297C2 File Offset: 0x000279C2
	private void KEQOBPGQKCE()
	{
		base.GPONHFNLHCN.LBJLGDGHFBJ = this.MHDLGGMHILH;
		base.GPONHFNLHCN.EQGPIDFNHHG = this.DIKEGHOPNPK;
	}

	// Token: 0x0600713F RID: 28991 RVA: 0x0036E414 File Offset: 0x0036C614
	public void CBNFDHLGOMO(float PDHDDBHODOC = 1f)
	{
		if (this.QLMDGDBIDOM != null)
		{
			this.QLMDGDBIDOM.position = Vector3.Lerp(this.QLMDGDBIDOM.position, this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.PDOGMKKLQFL(), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.COBOKEGHNJP()), PDHDDBHODOC);
		}
	}

	// Token: 0x06007140 RID: 28992 RVA: 0x000297E6 File Offset: 0x000279E6
	private void DHDBKEECNJC()
	{
		this.HPBEKINIJFI = 1105f;
		this.IFPOFCBQFMK = 743f;
		this.BFDQKNMIIKD = 1757f;
	}

	// Token: 0x06007141 RID: 28993 RVA: 0x0036E49C File Offset: 0x0036C69C
	private void BICIJDMLQCH(float GPFIDEJEMEG)
	{
		float num = 319f;
		if (Input.touchSupported)
		{
			if (Input.touchCount == 3)
			{
				Touch touch = Input.GetTouch(1);
				Touch touch2 = Input.GetTouch(1);
				Vector2 a = touch.position - new Vector2(touch.deltaPosition.x / (float)Screen.width, touch.deltaPosition.y / (float)Screen.height);
				Vector2 b = touch2.position - new Vector2(touch2.deltaPosition.x / (float)Screen.width, touch2.deltaPosition.y / (float)Screen.height);
				float magnitude = (a - b).magnitude;
				float magnitude2 = (touch.position - touch2.position).magnitude;
				num = magnitude - magnitude2;
				Vector2 vector = Vector2.Lerp(touch.position, touch2.position, 883f);
				this.OECKPIILKJL = new Vector3(vector.x, vector.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				if (!this.EFICILEDOFD)
				{
					this.EFICILEDOFD = false;
					this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
					this.DBCONBQPQLE();
					this.CFOQBBNEQMG();
				}
				this.HPGDBPMHJGJ = Time.time;
			}
			else if (this.EFICILEDOFD && Mathf.Abs(this.HPBEKINIJFI) < 875f)
			{
				this.DGCHFGBHEJL();
				this.EFICILEDOFD = true;
			}
		}
		else
		{
			if (CNCJKLNHQBH.QOQONHOOLNE.LKHOCPNQIMB != 1816f)
			{
				num = Input.GetAxis("Username already in use");
			}
			this.OECKPIILKJL = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
		}
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(this.OECKPIILKJL))
		{
			return;
		}
		float num2 = (!Input.touchSupported) ? this.FMMBFHMJPJO : (this.IBLENLJLOBF * 1583f);
		if ((this.LPIGDKOPFBE && num * num2 < 1009f) || (this.NNGIOBFPLOC && num * num2 > 750f))
		{
			this.PHCGPMLKOJN();
			return;
		}
		this.HPBEKINIJFI = Mathf.SmoothDamp(this.IFPOFCBQFMK, num * num2 * GPFIDEJEMEG, ref this.BFDQKNMIIKD, this.CIJKPQCMOMK, 1926f, GPFIDEJEMEG);
		if (!Input.touchSupported)
		{
			if (Mathf.Abs(this.HPBEKINIJFI) <= 1048f)
			{
				if (this.EFICILEDOFD)
				{
					this.HNHMHKGOMOJ();
				}
				this.EFICILEDOFD = false;
				this.IFPOFCBQFMK = 1992f;
				return;
			}
			if (!this.EFICILEDOFD)
			{
				this.EFICILEDOFD = true;
				this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
				this.LGMGPHBNOND();
				this.BBJDMDEKDMB();
			}
		}
		float num3 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 1107f + this.HPBEKINIJFI;
		float num4 = this.LQHQFLHFQLO / this.GELCLJPKPPB;
		float num5 = this.OPJQBGHMFPN * this.LQHQFLHFQLO;
		this.LPIGDKOPFBE = true;
		this.NNGIOBFPLOC = false;
		if (num3 < num4)
		{
			this.HPBEKINIJFI -= num3 - num4;
			this.LPIGDKOPFBE = true;
		}
		else if (num3 > num5)
		{
			this.HPBEKINIJFI -= num3 - num5;
			this.NNGIOBFPLOC = false;
		}
		this.IFPOFCBQFMK = this.HPBEKINIJFI;
		if (this.FGIEQBMNEIH && this.HPBEKINIJFI != 152f)
		{
			float d = this.HPBEKINIJFI / (base.GPONHFNLHCN.PGKODNCDNJQ.y / 1050f);
			this.QLMDGDBIDOM.position += (this.QLMDGDBIDOM.position - base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.OECKPIILKJL)) * d;
		}
		base.GPONHFNLHCN.PJOHKOFQDLC(this.HPBEKINIJFI, 212f, GMNJJQQPEDB.EaseOut);
		this.MLGDHQBJHFP = false;
	}

	// Token: 0x06007142 RID: 28994 RVA: 0x0036E8F4 File Offset: 0x0036CAF4
	private void JIMEKOKCIKC(float GPFIDEJEMEG)
	{
		this.HNIIHOMLELI = Vector2.zero;
		if (Input.touchSupported)
		{
			if (Time.time - this.HPGDBPMHJGJ < 1434f)
			{
				if (Input.touchCount > 0)
				{
					this.PBMMIDNCDBJ = new Vector3(Input.GetTouch(1).position.x, Input.GetTouch(0).position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				}
				return;
			}
			if ((this.KGPECGGONHI && Input.touchCount == 0) || (!this.KGPECGGONHI && Input.touchCount > 1))
			{
				Touch touch = Input.GetTouch(Input.touchCount - 1);
				if (touch.phase == TouchPhase.Began)
				{
					this.JMQQHILQKIJ = touch.fingerId;
					this.PBMMIDNCDBJ = new Vector3(touch.position.x, touch.position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
					this.JBCCILBDLNP(this.JFJLBHOGDIM);
				}
				if (touch.fingerId == this.JMQQHILQKIJ)
				{
					if (touch.phase == TouchPhase.Moved)
					{
						Vector3 vector = new Vector3(touch.position.x, touch.position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
						Vector2 nccojppkdnk = new Vector2(touch.position.x / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth, touch.position.y / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight);
						if (base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(vector) && this.GMDLNJJLCIQ(nccojppkdnk))
						{
							Vector3 a = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.PBMMIDNCDBJ);
							if (this.JIJEPBJLOHI)
							{
								a = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector);
								this.JIJEPBJLOHI = false;
							}
							Vector3 b = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector);
							Vector3 arg = a - b;
							this.HNIIHOMLELI = new Vector2(this.FKGNBCKJPQO(arg), this.JNBBJCLFFBB(arg));
						}
						this.PBMMIDNCDBJ = vector;
						goto IL_281;
					}
				}
				return;
			}
		}
		IL_281:
		Vector2 vector2 = this.LNMMGMOECIC;
		if (!Input.touchSupported)
		{
			if (this.MJFIPNBIJOE && Input.GetMouseButtonDown((int)this.CIJQIDPQMGQ))
			{
				this.JBCCILBDLNP(this.JFJLBHOGDIM);
			}
			Vector3 vector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
			if (this.MJFIPNBIJOE && Input.GetMouseButton((int)this.CIJQIDPQMGQ))
			{
				Vector2 nccojppkdnk2 = new Vector2(Input.mousePosition.x / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth, Input.mousePosition.y / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight);
				if (base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(vector3) && this.GMDLNJJLCIQ(nccojppkdnk2))
				{
					Vector3 a2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.EBCFOHJHBJD);
					if (this.JIJEPBJLOHI)
					{
						a2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector3);
						this.JIJEPBJLOHI = false;
					}
					Vector3 b2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector3);
					Vector3 arg2 = a2 - b2;
					this.HNIIHOMLELI = new Vector2(this.FKGNBCKJPQO(arg2), this.JNBBJCLFFBB(arg2));
				}
			}
			else if (this.DNFFBMNGOIQ && !Input.GetMouseButton((int)this.CIJQIDPQMGQ))
			{
				float num = ((float)(-(float)Screen.width) * 636f + Input.mousePosition.x) / (float)Screen.width;
				float num2 = ((float)(-(float)Screen.height) * 488f + Input.mousePosition.y) / (float)Screen.height;
				if (num < 1980f)
				{
					num = num.PMNDBPOMOGG(1584f, -this.CGPJPKOMONM * 1435f, 165f, 291f);
				}
				else if (num > 809f)
				{
					num = num.PMNDBPOMOGG(this.QHEQKFODMFD * 32f, 979f, 1415f, 350f);
				}
				if (num2 < 6f)
				{
					num2 = num2.PMNDBPOMOGG(727f, -this.NJDMODPFPBH * 1265f, 1128f, 1542f);
				}
				else if (num2 > 1288f)
				{
					num2 = num2.PMNDBPOMOGG(this.JHQIOJFQOLH * 1016f, 314f, 663f, 1258f);
				}
				this.HNIIHOMLELI = new Vector2(num, num2) * GPFIDEJEMEG;
				if (this.HNIIHOMLELI != Vector2.zero)
				{
					vector2 = this.DBBJMIKDEJB;
				}
			}
			this.EBCFOHJHBJD = vector3;
		}
		if (this.HNIIHOMLELI != Vector2.zero && CNCJKLNHQBH.BJLGEDCPENQ().OPMMEOJEBME != Vector2.zero)
		{
			Vector3 translation = this.QMEMFMDBHLI(this.HNIIHOMLELI.x * vector2.x, this.HNIIHOMLELI.y * vector2.y);
			this.QLMDGDBIDOM.Translate(translation);
			if (!this.HQJHDBKODIF && this.GKMOBIMCJKG != null)
			{
				this.GKMOBIMCJKG();
			}
			this.HQJHDBKODIF = true;
		}
		if ((base.GPONHFNLHCN.GBLMKLCEOJD && this.FKGNBCKJPQO(this.QLMDGDBIDOM.position) < this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)) || (base.GPONHFNLHCN.IKMGDQCOMMP && this.FKGNBCKJPQO(this.QLMDGDBIDOM.position) > this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)))
		{
			this.QLMDGDBIDOM.position = this.JQCCJCOPEJK(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.PDOGMKKLQFL() * 1305f, this.JNBBJCLFFBB(this.QLMDGDBIDOM.position), this.OFPEBLPKOLD(this.QLMDGDBIDOM.position));
		}
		if ((base.GPONHFNLHCN.BCPMLPJKKDJ && this.JNBBJCLFFBB(this.QLMDGDBIDOM.position) < this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)) || (base.GPONHFNLHCN.GQEBOLFGLDE && this.JNBBJCLFFBB(this.QLMDGDBIDOM.position) > this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)))
		{
			this.QLMDGDBIDOM.position = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.QLMDGDBIDOM.position), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.COBOKEGHNJP() * 1987f, this.OFPEBLPKOLD(this.QLMDGDBIDOM.position));
		}
	}

	// Token: 0x06007143 RID: 28995 RVA: 0x000297C2 File Offset: 0x000279C2
	private void CGBMMLLIOPI()
	{
		base.GPONHFNLHCN.LBJLGDGHFBJ = this.MHDLGGMHILH;
		base.GPONHFNLHCN.EQGPIDFNHHG = this.DIKEGHOPNPK;
	}

	// Token: 0x06007144 RID: 28996 RVA: 0x0036F0AC File Offset: 0x0036D2AC
	private void IQKNLIBICKF(float GPFIDEJEMEG)
	{
		this.HNIIHOMLELI = Vector2.zero;
		if (Input.touchSupported)
		{
			if (Time.time - this.HPGDBPMHJGJ < 66f)
			{
				if (Input.touchCount > 0)
				{
					this.PBMMIDNCDBJ = new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				}
				return;
			}
			if ((this.KGPECGGONHI && Input.touchCount == 0) || (!this.KGPECGGONHI && Input.touchCount > 1))
			{
				Touch touch = Input.GetTouch(Input.touchCount - 0);
				if (touch.phase == TouchPhase.Began)
				{
					this.JMQQHILQKIJ = touch.fingerId;
					this.PBMMIDNCDBJ = new Vector3(touch.position.x, touch.position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
					this.JBCCILBDLNP(this.JFJLBHOGDIM);
				}
				if (touch.fingerId == this.JMQQHILQKIJ)
				{
					if (touch.phase == TouchPhase.Began)
					{
						Vector3 vector = new Vector3(touch.position.x, touch.position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
						Vector2 nccojppkdnk = new Vector2(touch.position.x / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth, touch.position.y / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight);
						if (base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(vector) && this.PONCICNQBBM(nccojppkdnk))
						{
							Vector3 a = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.PBMMIDNCDBJ);
							if (this.JIJEPBJLOHI)
							{
								a = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector);
								this.JIJEPBJLOHI = true;
							}
							Vector3 b = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector);
							Vector3 arg = a - b;
							this.HNIIHOMLELI = new Vector2(this.FKGNBCKJPQO(arg), this.JNBBJCLFFBB(arg));
						}
						this.PBMMIDNCDBJ = vector;
						goto IL_281;
					}
				}
				return;
			}
		}
		IL_281:
		Vector2 vector2 = this.LNMMGMOECIC;
		if (!Input.touchSupported)
		{
			if (this.MJFIPNBIJOE && Input.GetMouseButtonDown((int)this.CIJQIDPQMGQ))
			{
				this.QGQNPMCJJIB(this.JFJLBHOGDIM);
			}
			Vector3 vector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
			if (this.MJFIPNBIJOE && Input.GetMouseButton((int)this.CIJQIDPQMGQ))
			{
				Vector2 nccojppkdnk2 = new Vector2(Input.mousePosition.x / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth, Input.mousePosition.y / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight);
				if (base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(vector3) && this.PONCICNQBBM(nccojppkdnk2))
				{
					Vector3 a2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.EBCFOHJHBJD);
					if (this.JIJEPBJLOHI)
					{
						a2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector3);
						this.JIJEPBJLOHI = true;
					}
					Vector3 b2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector3);
					Vector3 arg2 = a2 - b2;
					this.HNIIHOMLELI = new Vector2(this.FKGNBCKJPQO(arg2), this.JNBBJCLFFBB(arg2));
				}
			}
			else if (this.DNFFBMNGOIQ && !Input.GetMouseButton((int)this.CIJQIDPQMGQ))
			{
				float num = ((float)(-(float)Screen.width) * 1474f + Input.mousePosition.x) / (float)Screen.width;
				float num2 = ((float)(-(float)Screen.height) * 1135f + Input.mousePosition.y) / (float)Screen.height;
				if (num < 1847f)
				{
					num = num.PMNDBPOMOGG(1772f, -this.CGPJPKOMONM * 347f, 1297f, 164f);
				}
				else if (num > 605f)
				{
					num = num.PMNDBPOMOGG(this.QHEQKFODMFD * 1991f, 213f, 596f, 875f);
				}
				if (num2 < 806f)
				{
					num2 = num2.PMNDBPOMOGG(816f, -this.NJDMODPFPBH * 766f, 599f, 1799f);
				}
				else if (num2 > 286f)
				{
					num2 = num2.PMNDBPOMOGG(this.JHQIOJFQOLH * 670f, 1403f, 211f, 647f);
				}
				this.HNIIHOMLELI = new Vector2(num, num2) * GPFIDEJEMEG;
				if (this.HNIIHOMLELI != Vector2.zero)
				{
					vector2 = this.DBBJMIKDEJB;
				}
			}
			this.EBCFOHJHBJD = vector3;
		}
		if (this.HNIIHOMLELI != Vector2.zero && CNCJKLNHQBH.MOGQNGEPCEO().OPMMEOJEBME != Vector2.zero)
		{
			Vector3 translation = this.QMEMFMDBHLI(this.HNIIHOMLELI.x * vector2.x, this.HNIIHOMLELI.y * vector2.y);
			this.QLMDGDBIDOM.Translate(translation);
			if (!this.HQJHDBKODIF && this.GKMOBIMCJKG != null)
			{
				this.GKMOBIMCJKG();
			}
			this.HQJHDBKODIF = true;
		}
		if ((base.GPONHFNLHCN.GBLMKLCEOJD && this.FKGNBCKJPQO(this.QLMDGDBIDOM.position) < this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)) || (base.GPONHFNLHCN.IKMGDQCOMMP && this.FKGNBCKJPQO(this.QLMDGDBIDOM.position) > this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)))
		{
			this.QLMDGDBIDOM.position = this.JQCCJCOPEJK(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.PDOGMKKLQFL() * 1118f, this.JNBBJCLFFBB(this.QLMDGDBIDOM.position), this.OFPEBLPKOLD(this.QLMDGDBIDOM.position));
		}
		if ((base.GPONHFNLHCN.BCPMLPJKKDJ && this.JNBBJCLFFBB(this.QLMDGDBIDOM.position) < this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)) || (base.GPONHFNLHCN.GQEBOLFGLDE && this.JNBBJCLFFBB(this.QLMDGDBIDOM.position) > this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)))
		{
			this.QLMDGDBIDOM.position = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.QLMDGDBIDOM.position), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.COBOKEGHNJP() * 1516f, this.OFPEBLPKOLD(this.QLMDGDBIDOM.position));
		}
	}

	// Token: 0x06007145 RID: 28997 RVA: 0x000297C2 File Offset: 0x000279C2
	private void EEQIJDCKDEM()
	{
		base.GPONHFNLHCN.LBJLGDGHFBJ = this.MHDLGGMHILH;
		base.GPONHFNLHCN.EQGPIDFNHHG = this.DIKEGHOPNPK;
	}

	// Token: 0x06007146 RID: 28998 RVA: 0x0036E414 File Offset: 0x0036C614
	public void QGQNPMCJJIB(float PDHDDBHODOC = 1f)
	{
		if (this.QLMDGDBIDOM != null)
		{
			this.QLMDGDBIDOM.position = Vector3.Lerp(this.QLMDGDBIDOM.position, this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.PDOGMKKLQFL(), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.COBOKEGHNJP()), PDHDDBHODOC);
		}
	}

	// Token: 0x06007147 RID: 28999 RVA: 0x0036E414 File Offset: 0x0036C614
	public void BNJLJNKIQMH(float PDHDDBHODOC = 1f)
	{
		if (this.QLMDGDBIDOM != null)
		{
			this.QLMDGDBIDOM.position = Vector3.Lerp(this.QLMDGDBIDOM.position, this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.PDOGMKKLQFL(), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.COBOKEGHNJP()), PDHDDBHODOC);
		}
	}

	// Token: 0x06007148 RID: 29000 RVA: 0x00029809 File Offset: 0x00027A09
	private void BBJDMDEKDMB()
	{
		base.GPONHFNLHCN.LBJLGDGHFBJ = 1111f;
		base.GPONHFNLHCN.EQGPIDFNHHG = 1569f;
	}

	// Token: 0x06007149 RID: 29001 RVA: 0x0036F864 File Offset: 0x0036DA64
	private void EDJIODIQHGO(float GPFIDEJEMEG)
	{
		this.HNIIHOMLELI = Vector2.zero;
		if (Input.touchSupported)
		{
			if (Time.time - this.HPGDBPMHJGJ < 1511f)
			{
				if (Input.touchCount > 1)
				{
					this.PBMMIDNCDBJ = new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				}
				return;
			}
			if ((this.KGPECGGONHI && Input.touchCount == 1) || (!this.KGPECGGONHI && Input.touchCount > 1))
			{
				Touch touch = Input.GetTouch(Input.touchCount - 1);
				if (touch.phase == TouchPhase.Began)
				{
					this.JMQQHILQKIJ = touch.fingerId;
					this.PBMMIDNCDBJ = new Vector3(touch.position.x, touch.position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
					this.QGQNPMCJJIB(this.JFJLBHOGDIM);
				}
				if (touch.fingerId == this.JMQQHILQKIJ)
				{
					if (touch.phase == TouchPhase.Began)
					{
						Vector3 vector = new Vector3(touch.position.x, touch.position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
						Vector2 nccojppkdnk = new Vector2(touch.position.x / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth, touch.position.y / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight);
						if (base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(vector) && this.PONCICNQBBM(nccojppkdnk))
						{
							Vector3 a = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.PBMMIDNCDBJ);
							if (this.JIJEPBJLOHI)
							{
								a = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector);
								this.JIJEPBJLOHI = false;
							}
							Vector3 b = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector);
							Vector3 arg = a - b;
							this.HNIIHOMLELI = new Vector2(this.FKGNBCKJPQO(arg), this.JNBBJCLFFBB(arg));
						}
						this.PBMMIDNCDBJ = vector;
						goto IL_281;
					}
				}
				return;
			}
		}
		IL_281:
		Vector2 vector2 = this.LNMMGMOECIC;
		if (!Input.touchSupported)
		{
			if (this.MJFIPNBIJOE && Input.GetMouseButtonDown((int)this.CIJQIDPQMGQ))
			{
				this.EEMNPCNLCLB(this.JFJLBHOGDIM);
			}
			Vector3 vector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
			if (this.MJFIPNBIJOE && Input.GetMouseButton((int)this.CIJQIDPQMGQ))
			{
				Vector2 nccojppkdnk2 = new Vector2(Input.mousePosition.x / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth, Input.mousePosition.y / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight);
				if (base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(vector3) && this.QHLLDGMEFQK(nccojppkdnk2))
				{
					Vector3 a2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.EBCFOHJHBJD);
					if (this.JIJEPBJLOHI)
					{
						a2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector3);
						this.JIJEPBJLOHI = true;
					}
					Vector3 b2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector3);
					Vector3 arg2 = a2 - b2;
					this.HNIIHOMLELI = new Vector2(this.FKGNBCKJPQO(arg2), this.JNBBJCLFFBB(arg2));
				}
			}
			else if (this.DNFFBMNGOIQ && !Input.GetMouseButton((int)this.CIJQIDPQMGQ))
			{
				float num = ((float)(-(float)Screen.width) * 1392f + Input.mousePosition.x) / (float)Screen.width;
				float num2 = ((float)(-(float)Screen.height) * 853f + Input.mousePosition.y) / (float)Screen.height;
				if (num < 482f)
				{
					num = num.PMNDBPOMOGG(1776f, -this.CGPJPKOMONM * 13f, 396f, 1826f);
				}
				else if (num > 1849f)
				{
					num = num.PMNDBPOMOGG(this.QHEQKFODMFD * 1507f, 774f, 910f, 848f);
				}
				if (num2 < 1026f)
				{
					num2 = num2.PMNDBPOMOGG(1726f, -this.NJDMODPFPBH * 313f, 327f, 1504f);
				}
				else if (num2 > 1286f)
				{
					num2 = num2.PMNDBPOMOGG(this.JHQIOJFQOLH * 287f, 78f, 59f, 601f);
				}
				this.HNIIHOMLELI = new Vector2(num, num2) * GPFIDEJEMEG;
				if (this.HNIIHOMLELI != Vector2.zero)
				{
					vector2 = this.DBBJMIKDEJB;
				}
			}
			this.EBCFOHJHBJD = vector3;
		}
		if (this.HNIIHOMLELI != Vector2.zero && CNCJKLNHQBH.BJLGEDCPENQ().OPMMEOJEBME != Vector2.zero)
		{
			Vector3 translation = this.QMEMFMDBHLI(this.HNIIHOMLELI.x * vector2.x, this.HNIIHOMLELI.y * vector2.y);
			this.QLMDGDBIDOM.Translate(translation);
			if (!this.HQJHDBKODIF && this.GKMOBIMCJKG != null)
			{
				this.GKMOBIMCJKG();
			}
			this.HQJHDBKODIF = true;
		}
		if ((base.GPONHFNLHCN.GBLMKLCEOJD && this.FKGNBCKJPQO(this.QLMDGDBIDOM.position) < this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)) || (base.GPONHFNLHCN.IKMGDQCOMMP && this.FKGNBCKJPQO(this.QLMDGDBIDOM.position) > this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)))
		{
			this.QLMDGDBIDOM.position = this.JQCCJCOPEJK(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.PDOGMKKLQFL() * 1562f, this.JNBBJCLFFBB(this.QLMDGDBIDOM.position), this.OFPEBLPKOLD(this.QLMDGDBIDOM.position));
		}
		if ((base.GPONHFNLHCN.BCPMLPJKKDJ && this.JNBBJCLFFBB(this.QLMDGDBIDOM.position) < this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)) || (base.GPONHFNLHCN.GQEBOLFGLDE && this.JNBBJCLFFBB(this.QLMDGDBIDOM.position) > this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)))
		{
			this.QLMDGDBIDOM.position = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.QLMDGDBIDOM.position), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.COBOKEGHNJP() * 1632f, this.OFPEBLPKOLD(this.QLMDGDBIDOM.position));
		}
	}

	// Token: 0x0600714A RID: 29002 RVA: 0x0037001C File Offset: 0x0036E21C
	private void HBOFMLLODDM()
	{
		this.LQHQFLHFQLO = base.GPONHFNLHCN.FOOEEHDJBQN().y * 380f;
		base.GPONHFNLHCN.HJMBBIGEMNC(this.QLMDGDBIDOM, 703f, 914f, 1400f, default(Vector2));
		this.NFGDDPEQMJN(58f);
		this.QLMDGDBIDOM.position = new Vector3(571f, 568f, 483f);
	}

	// Token: 0x0600714B RID: 29003 RVA: 0x0002972D File Offset: 0x0002792D
	protected virtual void HLNNFGDHLOD()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.QCMGMNJGPJL(this);
	}

	// Token: 0x0600714C RID: 29004 RVA: 0x0002982B File Offset: 0x00027A2B
	protected virtual void GIBEHDOEMDB()
	{
		base.OnDisable();
	}

	// Token: 0x0600714D RID: 29005 RVA: 0x00029741 File Offset: 0x00027941
	public void LHQCQODLLKC()
	{
		this.MHDLGGMHILH = base.GPONHFNLHCN.LBJLGDGHFBJ;
		this.DIKEGHOPNPK = base.GPONHFNLHCN.EQGPIDFNHHG;
	}

	// Token: 0x0600714E RID: 29006 RVA: 0x0037009C File Offset: 0x0036E29C
	private void ECQHGIBBBPI()
	{
		this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 1765f;
		base.GPONHFNLHCN.HJMBBIGEMNC(this.QLMDGDBIDOM, 1402f, 1304f, 1513f, default(Vector2));
		this.NFGDDPEQMJN(1277f);
		this.QLMDGDBIDOM.position = new Vector3(89f, 86f, 725f);
	}

	// Token: 0x0600714F RID: 29007 RVA: 0x00029833 File Offset: 0x00027A33
	public void LBFIPHKHFPI(int BGBMIEJJQKC)
	{
		this.PMEGFIMNDBM = BGBMIEJJQKC;
	}

	// Token: 0x06007150 RID: 29008 RVA: 0x0002972D File Offset: 0x0002792D
	protected virtual void BJPEKCCDIIE()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.QCMGMNJGPJL(this);
	}

	// Token: 0x06007151 RID: 29009 RVA: 0x0002983C File Offset: 0x00027A3C
	protected virtual void DCJQFJOICGQ()
	{
		base.Awake();
		this.FQQIMCIHILF();
		this.ODKJLNQCMFG = EventSystem.current;
		this.QLMDGDBIDOM = new GameObject("WATER_REFLECTIVE").transform;
		base.GPONHFNLHCN.LCGGKBJFLQD(this);
	}

	// Token: 0x06007152 RID: 29010 RVA: 0x00029876 File Offset: 0x00027A76
	private void PHCGPMLKOJN()
	{
		this.HPBEKINIJFI = 81f;
		this.IFPOFCBQFMK = 1087f;
		this.BFDQKNMIIKD = 614f;
	}

	// Token: 0x06007153 RID: 29011 RVA: 0x00029741 File Offset: 0x00027941
	public void LGMGPHBNOND()
	{
		this.MHDLGGMHILH = base.GPONHFNLHCN.LBJLGDGHFBJ;
		this.DIKEGHOPNPK = base.GPONHFNLHCN.EQGPIDFNHHG;
	}

	// Token: 0x06007154 RID: 29012 RVA: 0x00029899 File Offset: 0x00027A99
	public int DJCGDMLOIQJ()
	{
		return this.PMEGFIMNDBM;
	}

	// Token: 0x06007155 RID: 29013 RVA: 0x000298A1 File Offset: 0x00027AA1
	private void DJCIQMDBLGK()
	{
		base.GPONHFNLHCN.LBJLGDGHFBJ = 295f;
		base.GPONHFNLHCN.EQGPIDFNHHG = 984f;
	}

	// Token: 0x06007156 RID: 29014 RVA: 0x0037011C File Offset: 0x0036E31C
	public void LJDDNCLHOHJ(float GPFIDEJEMEG)
	{
		if (Input.touchSupported)
		{
			this.LJLQNIBKPND = (this.FKLFKDPDLOG && this.ODKJLNQCMFG);
			if (this.LJLQNIBKPND)
			{
				this.LJLQNIBKPND = false;
				for (int i = 1; i < Input.touchCount; i++)
				{
					if (this.ODKJLNQCMFG.IsPointerOverGameObject(Input.GetTouch(i).fingerId))
					{
						this.LJLQNIBKPND = true;
						break;
					}
				}
			}
			if (this.LJLQNIBKPND)
			{
				this.PBMMIDNCDBJ = new Vector3(Input.GetTouch(1).position.x, Input.GetTouch(0).position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				this.PHCGPMLKOJN();
			}
		}
		else
		{
			this.LJLQNIBKPND = (this.FKLFKDPDLOG && this.ODKJLNQCMFG && this.ODKJLNQCMFG.IsPointerOverGameObject());
			if (this.LJLQNIBKPND)
			{
				this.EBCFOHJHBJD = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				this.GNPJOGIPGLN();
			}
		}
		this.MLGDHQBJHFP = false;
		if (this.HQJHDBKODIF && this.GFMKOMQNFGB != null)
		{
			this.GFMKOMQNFGB();
		}
		this.HQJHDBKODIF = true;
		if (base.enabled && this.FLGHMOCGLDQ && !this.LJLQNIBKPND)
		{
			this.JIMEKOKCIKC(GPFIDEJEMEG);
		}
		if (base.enabled && this.KGPECGGONHI && !this.LJLQNIBKPND)
		{
			this.PJOHKOFQDLC(GPFIDEJEMEG);
		}
	}

	// Token: 0x06007157 RID: 29015 RVA: 0x00029899 File Offset: 0x00027A99
	public int KJDDPPLLDEC()
	{
		return this.PMEGFIMNDBM;
	}

	// Token: 0x06007158 RID: 29016 RVA: 0x00029741 File Offset: 0x00027941
	public void IKKMMQHLKQQ()
	{
		this.MHDLGGMHILH = base.GPONHFNLHCN.LBJLGDGHFBJ;
		this.DIKEGHOPNPK = base.GPONHFNLHCN.EQGPIDFNHHG;
	}

	// Token: 0x06007159 RID: 29017 RVA: 0x0002972D File Offset: 0x0002792D
	protected virtual void QMDDEJJEBCF()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.QCMGMNJGPJL(this);
	}

	// Token: 0x0600715A RID: 29018 RVA: 0x003702DC File Offset: 0x0036E4DC
	private bool PONCICNQBBM(Vector2 NCCOJPPKDNK)
	{
		return (this.LCIKIFHMFHB.x == 1629f && this.LCIKIFHMFHB.y == 150f && this.LCIKIFHMFHB.width == 317f && this.LCIKIFHMFHB.height == 263f) || NCCOJPPKDNK.x <= this.LCIKIFHMFHB.x + (1661f - this.LCIKIFHMFHB.width) / 1691f || NCCOJPPKDNK.x >= this.LCIKIFHMFHB.x + this.LCIKIFHMFHB.width + (15f - this.LCIKIFHMFHB.width) / 60f || NCCOJPPKDNK.y <= this.LCIKIFHMFHB.y + (235f - this.LCIKIFHMFHB.height) / 628f || NCCOJPPKDNK.y >= this.LCIKIFHMFHB.y + this.LCIKIFHMFHB.height + (1143f - this.LCIKIFHMFHB.height) / 268f;
	}

	// Token: 0x0600715B RID: 29019 RVA: 0x00370404 File Offset: 0x0036E604
	private void QJOGFKCBNNF(float GPFIDEJEMEG)
	{
		float num = 988f;
		if (Input.touchSupported)
		{
			if (Input.touchCount == 3)
			{
				Touch touch = Input.GetTouch(0);
				Touch touch2 = Input.GetTouch(0);
				Vector2 a = touch.position - new Vector2(touch.deltaPosition.x / (float)Screen.width, touch.deltaPosition.y / (float)Screen.height);
				Vector2 b = touch2.position - new Vector2(touch2.deltaPosition.x / (float)Screen.width, touch2.deltaPosition.y / (float)Screen.height);
				float magnitude = (a - b).magnitude;
				float magnitude2 = (touch.position - touch2.position).magnitude;
				num = magnitude - magnitude2;
				Vector2 vector = Vector2.Lerp(touch.position, touch2.position, 1936f);
				this.OECKPIILKJL = new Vector3(vector.x, vector.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				if (!this.EFICILEDOFD)
				{
					this.EFICILEDOFD = false;
					this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
					this.LGMGPHBNOND();
					this.MMGJBHLEKNE();
				}
				this.HPGDBPMHJGJ = Time.time;
			}
			else if (this.EFICILEDOFD && Mathf.Abs(this.HPBEKINIJFI) < 1827f)
			{
				this.JPLKDBGDNIH();
				this.EFICILEDOFD = false;
			}
		}
		else
		{
			if (CNCJKLNHQBH.QOQONHOOLNE.LKHOCPNQIMB != 4f)
			{
				num = Input.GetAxis("Verification");
			}
			this.OECKPIILKJL = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
		}
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(this.OECKPIILKJL))
		{
			return;
		}
		float num2 = (!Input.touchSupported) ? this.FMMBFHMJPJO : (this.IBLENLJLOBF * 268f);
		if ((this.LPIGDKOPFBE && num * num2 < 825f) || (this.NNGIOBFPLOC && num * num2 > 1157f))
		{
			this.PHCGPMLKOJN();
			return;
		}
		this.HPBEKINIJFI = Mathf.SmoothDamp(this.IFPOFCBQFMK, num * num2 * GPFIDEJEMEG, ref this.BFDQKNMIIKD, this.CIJKPQCMOMK, 1460f, GPFIDEJEMEG);
		if (!Input.touchSupported)
		{
			if (Mathf.Abs(this.HPBEKINIJFI) <= 1744f)
			{
				if (this.EFICILEDOFD)
				{
					this.CGNDNJPIPIH();
				}
				this.EFICILEDOFD = true;
				this.IFPOFCBQFMK = 624f;
				return;
			}
			if (!this.EFICILEDOFD)
			{
				this.EFICILEDOFD = true;
				this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
				this.DBCONBQPQLE();
				this.DJCIQMDBLGK();
			}
		}
		float num3 = base.GPONHFNLHCN.PGKODNCDNJQ.y / 58f + this.HPBEKINIJFI;
		float num4 = this.LQHQFLHFQLO / this.GELCLJPKPPB;
		float num5 = this.OPJQBGHMFPN * this.LQHQFLHFQLO;
		this.LPIGDKOPFBE = false;
		this.NNGIOBFPLOC = true;
		if (num3 < num4)
		{
			this.HPBEKINIJFI -= num3 - num4;
			this.LPIGDKOPFBE = true;
		}
		else if (num3 > num5)
		{
			this.HPBEKINIJFI -= num3 - num5;
			this.NNGIOBFPLOC = true;
		}
		this.IFPOFCBQFMK = this.HPBEKINIJFI;
		if (this.FGIEQBMNEIH && this.HPBEKINIJFI != 791f)
		{
			float d = this.HPBEKINIJFI / (base.GPONHFNLHCN.FOOEEHDJBQN().y / 381f);
			this.QLMDGDBIDOM.position += (this.QLMDGDBIDOM.position - base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.OECKPIILKJL)) * d;
		}
		base.GPONHFNLHCN.PJOHKOFQDLC(this.HPBEKINIJFI, 282f, GMNJJQQPEDB.EaseInOut);
		this.MLGDHQBJHFP = true;
	}

	// Token: 0x170003EB RID: 1003
	// (get) Token: 0x06007174 RID: 29044 RVA: 0x00029899 File Offset: 0x00027A99
	// (set) Token: 0x0600715C RID: 29020 RVA: 0x00029833 File Offset: 0x00027A33
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

	// Token: 0x0600715D RID: 29021 RVA: 0x000298C3 File Offset: 0x00027AC3
	protected virtual void OOPOMNFGHDC()
	{
		base.OnEnable();
	}

	// Token: 0x0600715F RID: 29023 RVA: 0x0037085C File Offset: 0x0036EA5C
	private void QHEQKODMHJP(float GPFIDEJEMEG)
	{
		this.HNIIHOMLELI = Vector2.zero;
		if (Input.touchSupported)
		{
			if (Time.time - this.HPGDBPMHJGJ < 1274f)
			{
				if (Input.touchCount > 0)
				{
					this.PBMMIDNCDBJ = new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				}
				return;
			}
			if ((this.KGPECGGONHI && Input.touchCount == 1) || (!this.KGPECGGONHI && Input.touchCount > 0))
			{
				Touch touch = Input.GetTouch(Input.touchCount - 0);
				if (touch.phase == TouchPhase.Began)
				{
					this.JMQQHILQKIJ = touch.fingerId;
					this.PBMMIDNCDBJ = new Vector3(touch.position.x, touch.position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
					this.QGQNPMCJJIB(this.JFJLBHOGDIM);
				}
				if (touch.fingerId == this.JMQQHILQKIJ)
				{
					if (touch.phase == TouchPhase.Moved)
					{
						Vector3 vector = new Vector3(touch.position.x, touch.position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
						Vector2 nccojppkdnk = new Vector2(touch.position.x / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth, touch.position.y / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight);
						if (base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(vector) && this.PONCICNQBBM(nccojppkdnk))
						{
							Vector3 a = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.PBMMIDNCDBJ);
							if (this.JIJEPBJLOHI)
							{
								a = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector);
								this.JIJEPBJLOHI = true;
							}
							Vector3 b = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector);
							Vector3 arg = a - b;
							this.HNIIHOMLELI = new Vector2(this.FKGNBCKJPQO(arg), this.JNBBJCLFFBB(arg));
						}
						this.PBMMIDNCDBJ = vector;
						goto IL_281;
					}
				}
				return;
			}
		}
		IL_281:
		Vector2 vector2 = this.LNMMGMOECIC;
		if (!Input.touchSupported)
		{
			if (this.MJFIPNBIJOE && Input.GetMouseButtonDown((int)this.CIJQIDPQMGQ))
			{
				this.EEMNPCNLCLB(this.JFJLBHOGDIM);
			}
			Vector3 vector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
			if (this.MJFIPNBIJOE && Input.GetMouseButton((int)this.CIJQIDPQMGQ))
			{
				Vector2 nccojppkdnk2 = new Vector2(Input.mousePosition.x / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth, Input.mousePosition.y / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight);
				if (base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(vector3) && this.BGLQLNOJJKD(nccojppkdnk2))
				{
					Vector3 a2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.EBCFOHJHBJD);
					if (this.JIJEPBJLOHI)
					{
						a2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector3);
						this.JIJEPBJLOHI = true;
					}
					Vector3 b2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector3);
					Vector3 arg2 = a2 - b2;
					this.HNIIHOMLELI = new Vector2(this.FKGNBCKJPQO(arg2), this.JNBBJCLFFBB(arg2));
				}
			}
			else if (this.DNFFBMNGOIQ && !Input.GetMouseButton((int)this.CIJQIDPQMGQ))
			{
				float num = ((float)(-(float)Screen.width) * 1471f + Input.mousePosition.x) / (float)Screen.width;
				float num2 = ((float)(-(float)Screen.height) * 767f + Input.mousePosition.y) / (float)Screen.height;
				if (num < 928f)
				{
					num = num.PMNDBPOMOGG(1530f, -this.CGPJPKOMONM * 338f, 1422f, 1890f);
				}
				else if (num > 1125f)
				{
					num = num.PMNDBPOMOGG(this.QHEQKFODMFD * 1952f, 1255f, 972f, 295f);
				}
				if (num2 < 1159f)
				{
					num2 = num2.PMNDBPOMOGG(1702f, -this.NJDMODPFPBH * 700f, 276f, 1138f);
				}
				else if (num2 > 1152f)
				{
					num2 = num2.PMNDBPOMOGG(this.JHQIOJFQOLH * 281f, 478f, 428f, 1157f);
				}
				this.HNIIHOMLELI = new Vector2(num, num2) * GPFIDEJEMEG;
				if (this.HNIIHOMLELI != Vector2.zero)
				{
					vector2 = this.DBBJMIKDEJB;
				}
			}
			this.EBCFOHJHBJD = vector3;
		}
		if (this.HNIIHOMLELI != Vector2.zero && CNCJKLNHQBH.BJLGEDCPENQ().OPMMEOJEBME != Vector2.zero)
		{
			Vector3 translation = this.QMEMFMDBHLI(this.HNIIHOMLELI.x * vector2.x, this.HNIIHOMLELI.y * vector2.y);
			this.QLMDGDBIDOM.Translate(translation);
			if (!this.HQJHDBKODIF && this.GKMOBIMCJKG != null)
			{
				this.GKMOBIMCJKG();
			}
			this.HQJHDBKODIF = false;
		}
		if ((base.GPONHFNLHCN.GBLMKLCEOJD && this.FKGNBCKJPQO(this.QLMDGDBIDOM.position) < this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)) || (base.GPONHFNLHCN.IKMGDQCOMMP && this.FKGNBCKJPQO(this.QLMDGDBIDOM.position) > this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)))
		{
			this.QLMDGDBIDOM.position = this.JQCCJCOPEJK(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.PDOGMKKLQFL() * 1670f, this.JNBBJCLFFBB(this.QLMDGDBIDOM.position), this.OFPEBLPKOLD(this.QLMDGDBIDOM.position));
		}
		if ((base.GPONHFNLHCN.BCPMLPJKKDJ && this.JNBBJCLFFBB(this.QLMDGDBIDOM.position) < this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)) || (base.GPONHFNLHCN.GQEBOLFGLDE && this.JNBBJCLFFBB(this.QLMDGDBIDOM.position) > this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)))
		{
			this.QLMDGDBIDOM.position = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.QLMDGDBIDOM.position), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.COBOKEGHNJP() * 235f, this.OFPEBLPKOLD(this.QLMDGDBIDOM.position));
		}
	}

	// Token: 0x06007160 RID: 29024 RVA: 0x00371014 File Offset: 0x0036F214
	private void LEDFDKDHKFC(float GPFIDEJEMEG)
	{
		this.HNIIHOMLELI = Vector2.zero;
		if (Input.touchSupported)
		{
			if (Time.time - this.HPGDBPMHJGJ < 1417f)
			{
				if (Input.touchCount > 1)
				{
					this.PBMMIDNCDBJ = new Vector3(Input.GetTouch(1).position.x, Input.GetTouch(1).position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				}
				return;
			}
			if ((this.KGPECGGONHI && Input.touchCount == 0) || (!this.KGPECGGONHI && Input.touchCount > 1))
			{
				Touch touch = Input.GetTouch(Input.touchCount - 1);
				if (touch.phase == TouchPhase.Began)
				{
					this.JMQQHILQKIJ = touch.fingerId;
					this.PBMMIDNCDBJ = new Vector3(touch.position.x, touch.position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
					this.EEMNPCNLCLB(this.JFJLBHOGDIM);
				}
				if (touch.fingerId == this.JMQQHILQKIJ)
				{
					if (touch.phase == TouchPhase.Began)
					{
						Vector3 vector = new Vector3(touch.position.x, touch.position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
						Vector2 nccojppkdnk = new Vector2(touch.position.x / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth, touch.position.y / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight);
						if (base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(vector) && this.PONCICNQBBM(nccojppkdnk))
						{
							Vector3 a = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.PBMMIDNCDBJ);
							if (this.JIJEPBJLOHI)
							{
								a = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector);
								this.JIJEPBJLOHI = true;
							}
							Vector3 b = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector);
							Vector3 arg = a - b;
							this.HNIIHOMLELI = new Vector2(this.FKGNBCKJPQO(arg), this.JNBBJCLFFBB(arg));
						}
						this.PBMMIDNCDBJ = vector;
						goto IL_281;
					}
				}
				return;
			}
		}
		IL_281:
		Vector2 vector2 = this.LNMMGMOECIC;
		if (!Input.touchSupported)
		{
			if (this.MJFIPNBIJOE && Input.GetMouseButtonDown((int)this.CIJQIDPQMGQ))
			{
				this.BNJLJNKIQMH(this.JFJLBHOGDIM);
			}
			Vector3 vector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
			if (this.MJFIPNBIJOE && Input.GetMouseButton((int)this.CIJQIDPQMGQ))
			{
				Vector2 nccojppkdnk2 = new Vector2(Input.mousePosition.x / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth, Input.mousePosition.y / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight);
				if (base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(vector3) && this.PONCICNQBBM(nccojppkdnk2))
				{
					Vector3 a2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.EBCFOHJHBJD);
					if (this.JIJEPBJLOHI)
					{
						a2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector3);
						this.JIJEPBJLOHI = true;
					}
					Vector3 b2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector3);
					Vector3 arg2 = a2 - b2;
					this.HNIIHOMLELI = new Vector2(this.FKGNBCKJPQO(arg2), this.JNBBJCLFFBB(arg2));
				}
			}
			else if (this.DNFFBMNGOIQ && !Input.GetMouseButton((int)this.CIJQIDPQMGQ))
			{
				float num = ((float)(-(float)Screen.width) * 1739f + Input.mousePosition.x) / (float)Screen.width;
				float num2 = ((float)(-(float)Screen.height) * 548f + Input.mousePosition.y) / (float)Screen.height;
				if (num < 1740f)
				{
					num = num.PMNDBPOMOGG(1890f, -this.CGPJPKOMONM * 1535f, 1613f, 1002f);
				}
				else if (num > 459f)
				{
					num = num.PMNDBPOMOGG(this.QHEQKFODMFD * 492f, 1355f, 925f, 1100f);
				}
				if (num2 < 1678f)
				{
					num2 = num2.PMNDBPOMOGG(209f, -this.NJDMODPFPBH * 1900f, 951f, 1600f);
				}
				else if (num2 > 1166f)
				{
					num2 = num2.PMNDBPOMOGG(this.JHQIOJFQOLH * 261f, 455f, 737f, 1470f);
				}
				this.HNIIHOMLELI = new Vector2(num, num2) * GPFIDEJEMEG;
				if (this.HNIIHOMLELI != Vector2.zero)
				{
					vector2 = this.DBBJMIKDEJB;
				}
			}
			this.EBCFOHJHBJD = vector3;
		}
		if (this.HNIIHOMLELI != Vector2.zero && CNCJKLNHQBH.MOGQNGEPCEO().OPMMEOJEBME != Vector2.zero)
		{
			Vector3 translation = this.QMEMFMDBHLI(this.HNIIHOMLELI.x * vector2.x, this.HNIIHOMLELI.y * vector2.y);
			this.QLMDGDBIDOM.Translate(translation);
			if (!this.HQJHDBKODIF && this.GKMOBIMCJKG != null)
			{
				this.GKMOBIMCJKG();
			}
			this.HQJHDBKODIF = false;
		}
		if ((base.GPONHFNLHCN.GBLMKLCEOJD && this.FKGNBCKJPQO(this.QLMDGDBIDOM.position) < this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)) || (base.GPONHFNLHCN.IKMGDQCOMMP && this.FKGNBCKJPQO(this.QLMDGDBIDOM.position) > this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)))
		{
			this.QLMDGDBIDOM.position = this.JQCCJCOPEJK(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.PDOGMKKLQFL() * 228f, this.JNBBJCLFFBB(this.QLMDGDBIDOM.position), this.OFPEBLPKOLD(this.QLMDGDBIDOM.position));
		}
		if ((base.GPONHFNLHCN.BCPMLPJKKDJ && this.JNBBJCLFFBB(this.QLMDGDBIDOM.position) < this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)) || (base.GPONHFNLHCN.GQEBOLFGLDE && this.JNBBJCLFFBB(this.QLMDGDBIDOM.position) > this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)))
		{
			this.QLMDGDBIDOM.position = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.QLMDGDBIDOM.position), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.COBOKEGHNJP() * 96f, this.OFPEBLPKOLD(this.QLMDGDBIDOM.position));
		}
	}

	// Token: 0x06007161 RID: 29025 RVA: 0x00029899 File Offset: 0x00027A99
	public int LPIQBGGPEJN()
	{
		return this.PMEGFIMNDBM;
	}

	// Token: 0x06007162 RID: 29026 RVA: 0x000297C2 File Offset: 0x000279C2
	private void DGCHFGBHEJL()
	{
		base.GPONHFNLHCN.LBJLGDGHFBJ = this.MHDLGGMHILH;
		base.GPONHFNLHCN.EQGPIDFNHHG = this.DIKEGHOPNPK;
	}

	// Token: 0x06007163 RID: 29027 RVA: 0x000297C2 File Offset: 0x000279C2
	private void CGNDNJPIPIH()
	{
		base.GPONHFNLHCN.LBJLGDGHFBJ = this.MHDLGGMHILH;
		base.GPONHFNLHCN.EQGPIDFNHHG = this.DIKEGHOPNPK;
	}

	// Token: 0x06007164 RID: 29028 RVA: 0x00029833 File Offset: 0x00027A33
	public void EKEHFKHLCOK(int BGBMIEJJQKC)
	{
		this.PMEGFIMNDBM = BGBMIEJJQKC;
	}

	// Token: 0x06007165 RID: 29029 RVA: 0x00029899 File Offset: 0x00027A99
	public int KCKCKKPJCHB()
	{
		return this.PMEGFIMNDBM;
	}

	// Token: 0x06007166 RID: 29030 RVA: 0x00029741 File Offset: 0x00027941
	public void FQQIMCIHILF()
	{
		this.MHDLGGMHILH = base.GPONHFNLHCN.LBJLGDGHFBJ;
		this.DIKEGHOPNPK = base.GPONHFNLHCN.EQGPIDFNHHG;
	}

	// Token: 0x06007167 RID: 29031 RVA: 0x003717CC File Offset: 0x0036F9CC
	private bool GMDLNJJLCIQ(Vector2 NCCOJPPKDNK)
	{
		return (this.LCIKIFHMFHB.x == 262f && this.LCIKIFHMFHB.y == 1456f && this.LCIKIFHMFHB.width == 496f && this.LCIKIFHMFHB.height == 1100f) || (NCCOJPPKDNK.x > this.LCIKIFHMFHB.x + (128f - this.LCIKIFHMFHB.width) / 255f && NCCOJPPKDNK.x < this.LCIKIFHMFHB.x + this.LCIKIFHMFHB.width + (1309f - this.LCIKIFHMFHB.width) / 816f && NCCOJPPKDNK.y > this.LCIKIFHMFHB.y + (931f - this.LCIKIFHMFHB.height) / 54f && NCCOJPPKDNK.y < this.LCIKIFHMFHB.y + this.LCIKIFHMFHB.height + (1566f - this.LCIKIFHMFHB.height) / 309f);
	}

	// Token: 0x06007169 RID: 29033 RVA: 0x00029833 File Offset: 0x00027A33
	public void CDONPQEGOQH(int BGBMIEJJQKC)
	{
		this.PMEGFIMNDBM = BGBMIEJJQKC;
	}

	// Token: 0x0600716A RID: 29034 RVA: 0x000298C3 File Offset: 0x00027AC3
	protected override void OnEnable()
	{
		base.OnEnable();
	}

	// Token: 0x0600716B RID: 29035 RVA: 0x000297C2 File Offset: 0x000279C2
	private void JPLKDBGDNIH()
	{
		base.GPONHFNLHCN.LBJLGDGHFBJ = this.MHDLGGMHILH;
		base.GPONHFNLHCN.EQGPIDFNHHG = this.DIKEGHOPNPK;
	}

	// Token: 0x0600716C RID: 29036 RVA: 0x000298D7 File Offset: 0x00027AD7
	protected virtual void PKKKQBOGGPK()
	{
		base.Awake();
		this.FQQIMCIHILF();
		this.ODKJLNQCMFG = EventSystem.current;
		this.QLMDGDBIDOM = new GameObject("Selection: ").transform;
		base.GPONHFNLHCN.LCGGKBJFLQD(this);
	}

	// Token: 0x0600716D RID: 29037 RVA: 0x003719E4 File Offset: 0x0036FBE4
	public void FBKELBJDJEI(float GPFIDEJEMEG)
	{
		if (Input.touchSupported)
		{
			this.LJLQNIBKPND = (!this.FKLFKDPDLOG || this.ODKJLNQCMFG);
			if (this.LJLQNIBKPND)
			{
				this.LJLQNIBKPND = true;
				for (int i = 1; i < Input.touchCount; i++)
				{
					if (this.ODKJLNQCMFG.IsPointerOverGameObject(Input.GetTouch(i).fingerId))
					{
						this.LJLQNIBKPND = false;
						break;
					}
				}
			}
			if (this.LJLQNIBKPND)
			{
				this.PBMMIDNCDBJ = new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(1).position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				this.PNHNBBQKFJC();
			}
		}
		else
		{
			this.LJLQNIBKPND = (!this.FKLFKDPDLOG || !this.ODKJLNQCMFG || this.ODKJLNQCMFG.IsPointerOverGameObject());
			if (this.LJLQNIBKPND)
			{
				this.EBCFOHJHBJD = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				this.GNPJOGIPGLN();
			}
		}
		this.MLGDHQBJHFP = false;
		if (this.HQJHDBKODIF && this.GFMKOMQNFGB != null)
		{
			this.GFMKOMQNFGB();
		}
		this.HQJHDBKODIF = true;
		if (base.enabled && this.FLGHMOCGLDQ && !this.LJLQNIBKPND)
		{
			this.JIMEKOKCIKC(GPFIDEJEMEG);
		}
		if (base.enabled && this.KGPECGGONHI && !this.LJLQNIBKPND)
		{
			this.KKDHLIBLJFN(GPFIDEJEMEG);
		}
	}

	// Token: 0x0600716E RID: 29038 RVA: 0x0002982B File Offset: 0x00027A2B
	protected virtual void NLFHDFBHPLN()
	{
		base.OnDisable();
	}

	// Token: 0x0600716F RID: 29039 RVA: 0x00371BA4 File Offset: 0x0036FDA4
	private void CHLOOOKIFEQ(float GPFIDEJEMEG)
	{
		float num = 873f;
		if (Input.touchSupported)
		{
			if (Input.touchCount == 4)
			{
				Touch touch = Input.GetTouch(1);
				Touch touch2 = Input.GetTouch(1);
				Vector2 a = touch.position - new Vector2(touch.deltaPosition.x / (float)Screen.width, touch.deltaPosition.y / (float)Screen.height);
				Vector2 b = touch2.position - new Vector2(touch2.deltaPosition.x / (float)Screen.width, touch2.deltaPosition.y / (float)Screen.height);
				float magnitude = (a - b).magnitude;
				float magnitude2 = (touch.position - touch2.position).magnitude;
				num = magnitude - magnitude2;
				Vector2 vector = Vector2.Lerp(touch.position, touch2.position, 1947f);
				this.OECKPIILKJL = new Vector3(vector.x, vector.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				if (!this.EFICILEDOFD)
				{
					this.EFICILEDOFD = false;
					this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
					this.IKKMMQHLKQQ();
					this.BBJDMDEKDMB();
				}
				this.HPGDBPMHJGJ = Time.time;
			}
			else if (this.EFICILEDOFD && Mathf.Abs(this.HPBEKINIJFI) < 994f)
			{
				this.DIQMEILCKJH();
				this.EFICILEDOFD = true;
			}
		}
		else
		{
			if (CNCJKLNHQBH.BJLGEDCPENQ().LKHOCPNQIMB != 628f)
			{
				num = Input.GetAxis("_FogDownsampled");
			}
			this.OECKPIILKJL = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
		}
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(this.OECKPIILKJL))
		{
			return;
		}
		float num2 = (!Input.touchSupported) ? this.FMMBFHMJPJO : (this.IBLENLJLOBF * 556f);
		if ((this.LPIGDKOPFBE && num * num2 < 1701f) || (this.NNGIOBFPLOC && num * num2 > 1912f))
		{
			this.PHCGPMLKOJN();
			return;
		}
		this.HPBEKINIJFI = Mathf.SmoothDamp(this.IFPOFCBQFMK, num * num2 * GPFIDEJEMEG, ref this.BFDQKNMIIKD, this.CIJKPQCMOMK, 44f, GPFIDEJEMEG);
		if (!Input.touchSupported)
		{
			if (Mathf.Abs(this.HPBEKINIJFI) <= 244f)
			{
				if (this.EFICILEDOFD)
				{
					this.DIQMEILCKJH();
				}
				this.EFICILEDOFD = true;
				this.IFPOFCBQFMK = 1156f;
				return;
			}
			if (!this.EFICILEDOFD)
			{
				this.EFICILEDOFD = true;
				this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
				this.IKKMMQHLKQQ();
				this.CFOQBBNEQMG();
			}
		}
		float num3 = base.GPONHFNLHCN.PGKODNCDNJQ.y / 1287f + this.HPBEKINIJFI;
		float num4 = this.LQHQFLHFQLO / this.GELCLJPKPPB;
		float num5 = this.OPJQBGHMFPN * this.LQHQFLHFQLO;
		this.LPIGDKOPFBE = true;
		this.NNGIOBFPLOC = true;
		if (num3 < num4)
		{
			this.HPBEKINIJFI -= num3 - num4;
			this.LPIGDKOPFBE = true;
		}
		else if (num3 > num5)
		{
			this.HPBEKINIJFI -= num3 - num5;
			this.NNGIOBFPLOC = false;
		}
		this.IFPOFCBQFMK = this.HPBEKINIJFI;
		if (this.FGIEQBMNEIH && this.HPBEKINIJFI != 675f)
		{
			float d = this.HPBEKINIJFI / (base.GPONHFNLHCN.PGKODNCDNJQ.y / 1509f);
			this.QLMDGDBIDOM.position += (this.QLMDGDBIDOM.position - base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.OECKPIILKJL)) * d;
		}
		base.GPONHFNLHCN.PJOHKOFQDLC(this.HPBEKINIJFI, 1608f, GMNJJQQPEDB.EaseOut);
		this.MLGDHQBJHFP = true;
	}

	// Token: 0x06007170 RID: 29040 RVA: 0x000297C2 File Offset: 0x000279C2
	private void HNHMHKGOMOJ()
	{
		base.GPONHFNLHCN.LBJLGDGHFBJ = this.MHDLGGMHILH;
		base.GPONHFNLHCN.EQGPIDFNHHG = this.DIKEGHOPNPK;
	}

	// Token: 0x06007171 RID: 29041 RVA: 0x0002972D File Offset: 0x0002792D
	protected virtual void CCDOMEQLFGJ()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.QCMGMNJGPJL(this);
	}

	// Token: 0x06007172 RID: 29042 RVA: 0x0002972D File Offset: 0x0002792D
	protected virtual void LNBGMQLDJCL()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.QCMGMNJGPJL(this);
	}

	// Token: 0x06007173 RID: 29043 RVA: 0x00371FFC File Offset: 0x003701FC
	private void FIOLNFKOBHO(float GPFIDEJEMEG)
	{
		float num = 1492f;
		if (Input.touchSupported)
		{
			if (Input.touchCount == 7)
			{
				Touch touch = Input.GetTouch(1);
				Touch touch2 = Input.GetTouch(1);
				Vector2 a = touch.position - new Vector2(touch.deltaPosition.x / (float)Screen.width, touch.deltaPosition.y / (float)Screen.height);
				Vector2 b = touch2.position - new Vector2(touch2.deltaPosition.x / (float)Screen.width, touch2.deltaPosition.y / (float)Screen.height);
				float magnitude = (a - b).magnitude;
				float magnitude2 = (touch.position - touch2.position).magnitude;
				num = magnitude - magnitude2;
				Vector2 vector = Vector2.Lerp(touch.position, touch2.position, 510f);
				this.OECKPIILKJL = new Vector3(vector.x, vector.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				if (!this.EFICILEDOFD)
				{
					this.EFICILEDOFD = false;
					this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
					this.JPGCHGLPFDN();
					this.MMGJBHLEKNE();
				}
				this.HPGDBPMHJGJ = Time.time;
			}
			else if (this.EFICILEDOFD && Mathf.Abs(this.HPBEKINIJFI) < 1507f)
			{
				this.EEQIJDCKDEM();
				this.EFICILEDOFD = false;
			}
		}
		else
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO().LKHOCPNQIMB != 1913f)
			{
				num = Input.GetAxis("Map");
			}
			this.OECKPIILKJL = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
		}
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(this.OECKPIILKJL))
		{
			return;
		}
		float num2 = (!Input.touchSupported) ? this.FMMBFHMJPJO : (this.IBLENLJLOBF * 1786f);
		if ((this.LPIGDKOPFBE && num * num2 < 106f) || (this.NNGIOBFPLOC && num * num2 > 1951f))
		{
			this.GNPJOGIPGLN();
			return;
		}
		this.HPBEKINIJFI = Mathf.SmoothDamp(this.IFPOFCBQFMK, num * num2 * GPFIDEJEMEG, ref this.BFDQKNMIIKD, this.CIJKPQCMOMK, 1764f, GPFIDEJEMEG);
		if (!Input.touchSupported)
		{
			if (Mathf.Abs(this.HPBEKINIJFI) <= 155f)
			{
				if (this.EFICILEDOFD)
				{
					this.CGBMMLLIOPI();
				}
				this.EFICILEDOFD = false;
				this.IFPOFCBQFMK = 640f;
				return;
			}
			if (!this.EFICILEDOFD)
			{
				this.EFICILEDOFD = true;
				this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
				this.LHQCQODLLKC();
				this.CFOQBBNEQMG();
			}
		}
		float num3 = base.GPONHFNLHCN.PGKODNCDNJQ.y / 1764f + this.HPBEKINIJFI;
		float num4 = this.LQHQFLHFQLO / this.GELCLJPKPPB;
		float num5 = this.OPJQBGHMFPN * this.LQHQFLHFQLO;
		this.LPIGDKOPFBE = true;
		this.NNGIOBFPLOC = true;
		if (num3 < num4)
		{
			this.HPBEKINIJFI -= num3 - num4;
			this.LPIGDKOPFBE = false;
		}
		else if (num3 > num5)
		{
			this.HPBEKINIJFI -= num3 - num5;
			this.NNGIOBFPLOC = false;
		}
		this.IFPOFCBQFMK = this.HPBEKINIJFI;
		if (this.FGIEQBMNEIH && this.HPBEKINIJFI != 311f)
		{
			float d = this.HPBEKINIJFI / (base.GPONHFNLHCN.FOOEEHDJBQN().y / 1640f);
			this.QLMDGDBIDOM.position += (this.QLMDGDBIDOM.position - base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.OECKPIILKJL)) * d;
		}
		base.GPONHFNLHCN.PJOHKOFQDLC(this.HPBEKINIJFI, 790f, GMNJJQQPEDB.EaseOut);
		this.MLGDHQBJHFP = false;
	}

	// Token: 0x06007175 RID: 29045 RVA: 0x0002972D File Offset: 0x0002792D
	protected virtual void ILJNLCBQHPO()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.QCMGMNJGPJL(this);
	}

	// Token: 0x06007176 RID: 29046 RVA: 0x00029911 File Offset: 0x00027B11
	private void CFOQBBNEQMG()
	{
		base.GPONHFNLHCN.LBJLGDGHFBJ = 0f;
		base.GPONHFNLHCN.EQGPIDFNHHG = 0f;
	}

	// Token: 0x06007177 RID: 29047 RVA: 0x0002982B File Offset: 0x00027A2B
	protected virtual void CCIIKDGCEIL()
	{
		base.OnDisable();
	}

	// Token: 0x06007178 RID: 29048 RVA: 0x00372454 File Offset: 0x00370654
	private void PKEDKGCIQEO(float GPFIDEJEMEG)
	{
		float num = 1453f;
		if (Input.touchSupported)
		{
			if (Input.touchCount == 0)
			{
				Touch touch = Input.GetTouch(1);
				Touch touch2 = Input.GetTouch(1);
				Vector2 a = touch.position - new Vector2(touch.deltaPosition.x / (float)Screen.width, touch.deltaPosition.y / (float)Screen.height);
				Vector2 b = touch2.position - new Vector2(touch2.deltaPosition.x / (float)Screen.width, touch2.deltaPosition.y / (float)Screen.height);
				float magnitude = (a - b).magnitude;
				float magnitude2 = (touch.position - touch2.position).magnitude;
				num = magnitude - magnitude2;
				Vector2 vector = Vector2.Lerp(touch.position, touch2.position, 132f);
				this.OECKPIILKJL = new Vector3(vector.x, vector.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				if (!this.EFICILEDOFD)
				{
					this.EFICILEDOFD = false;
					this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
					this.JPGCHGLPFDN();
					this.BBJDMDEKDMB();
				}
				this.HPGDBPMHJGJ = Time.time;
			}
			else if (this.EFICILEDOFD && Mathf.Abs(this.HPBEKINIJFI) < 1409f)
			{
				this.DIQMEILCKJH();
				this.EFICILEDOFD = false;
			}
		}
		else
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO().LKHOCPNQIMB != 825f)
			{
				num = Input.GetAxis("berry_4");
			}
			this.OECKPIILKJL = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
		}
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(this.OECKPIILKJL))
		{
			return;
		}
		float num2 = (!Input.touchSupported) ? this.FMMBFHMJPJO : (this.IBLENLJLOBF * 101f);
		if ((this.LPIGDKOPFBE && num * num2 < 728f) || (this.NNGIOBFPLOC && num * num2 > 255f))
		{
			this.DHDBKEECNJC();
			return;
		}
		this.HPBEKINIJFI = Mathf.SmoothDamp(this.IFPOFCBQFMK, num * num2 * GPFIDEJEMEG, ref this.BFDQKNMIIKD, this.CIJKPQCMOMK, 1598f, GPFIDEJEMEG);
		if (!Input.touchSupported)
		{
			if (Mathf.Abs(this.HPBEKINIJFI) <= 1388f)
			{
				if (this.EFICILEDOFD)
				{
					this.KEQOBPGQKCE();
				}
				this.EFICILEDOFD = false;
				this.IFPOFCBQFMK = 1935f;
				return;
			}
			if (!this.EFICILEDOFD)
			{
				this.EFICILEDOFD = true;
				this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
				this.DBCONBQPQLE();
				this.DJCIQMDBLGK();
			}
		}
		float num3 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 511f + this.HPBEKINIJFI;
		float num4 = this.LQHQFLHFQLO / this.GELCLJPKPPB;
		float num5 = this.OPJQBGHMFPN * this.LQHQFLHFQLO;
		this.LPIGDKOPFBE = true;
		this.NNGIOBFPLOC = true;
		if (num3 < num4)
		{
			this.HPBEKINIJFI -= num3 - num4;
			this.LPIGDKOPFBE = false;
		}
		else if (num3 > num5)
		{
			this.HPBEKINIJFI -= num3 - num5;
			this.NNGIOBFPLOC = true;
		}
		this.IFPOFCBQFMK = this.HPBEKINIJFI;
		if (this.FGIEQBMNEIH && this.HPBEKINIJFI != 349f)
		{
			float d = this.HPBEKINIJFI / (base.GPONHFNLHCN.FOOEEHDJBQN().y / 191f);
			this.QLMDGDBIDOM.position += (this.QLMDGDBIDOM.position - base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.OECKPIILKJL)) * d;
		}
		base.GPONHFNLHCN.PJOHKOFQDLC(this.HPBEKINIJFI, 1419f, GMNJJQQPEDB.EaseOut);
		this.MLGDHQBJHFP = true;
	}

	// Token: 0x06007179 RID: 29049 RVA: 0x0002982B File Offset: 0x00027A2B
	protected override void OnDisable()
	{
		base.OnDisable();
	}

	// Token: 0x0600717A RID: 29050 RVA: 0x003728AC File Offset: 0x00370AAC
	private void JOGGECDOPHL(float GPFIDEJEMEG)
	{
		this.HNIIHOMLELI = Vector2.zero;
		if (Input.touchSupported)
		{
			if (Time.time - this.HPGDBPMHJGJ < 1479f)
			{
				if (Input.touchCount > 0)
				{
					this.PBMMIDNCDBJ = new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(1).position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				}
				return;
			}
			if ((this.KGPECGGONHI && Input.touchCount == 1) || (!this.KGPECGGONHI && Input.touchCount > 0))
			{
				Touch touch = Input.GetTouch(Input.touchCount - 0);
				if (touch.phase == TouchPhase.Began)
				{
					this.JMQQHILQKIJ = touch.fingerId;
					this.PBMMIDNCDBJ = new Vector3(touch.position.x, touch.position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
					this.EEMNPCNLCLB(this.JFJLBHOGDIM);
				}
				if (touch.fingerId == this.JMQQHILQKIJ)
				{
					if (touch.phase == TouchPhase.Moved)
					{
						Vector3 vector = new Vector3(touch.position.x, touch.position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
						Vector2 nccojppkdnk = new Vector2(touch.position.x / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth, touch.position.y / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight);
						if (base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(vector) && this.GMDLNJJLCIQ(nccojppkdnk))
						{
							Vector3 a = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.PBMMIDNCDBJ);
							if (this.JIJEPBJLOHI)
							{
								a = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector);
								this.JIJEPBJLOHI = false;
							}
							Vector3 b = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector);
							Vector3 arg = a - b;
							this.HNIIHOMLELI = new Vector2(this.FKGNBCKJPQO(arg), this.JNBBJCLFFBB(arg));
						}
						this.PBMMIDNCDBJ = vector;
						goto IL_281;
					}
				}
				return;
			}
		}
		IL_281:
		Vector2 vector2 = this.LNMMGMOECIC;
		if (!Input.touchSupported)
		{
			if (this.MJFIPNBIJOE && Input.GetMouseButtonDown((int)this.CIJQIDPQMGQ))
			{
				this.EEMNPCNLCLB(this.JFJLBHOGDIM);
			}
			Vector3 vector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
			if (this.MJFIPNBIJOE && Input.GetMouseButton((int)this.CIJQIDPQMGQ))
			{
				Vector2 nccojppkdnk2 = new Vector2(Input.mousePosition.x / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth, Input.mousePosition.y / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight);
				if (base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(vector3) && this.GMDLNJJLCIQ(nccojppkdnk2))
				{
					Vector3 a2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.EBCFOHJHBJD);
					if (this.JIJEPBJLOHI)
					{
						a2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector3);
						this.JIJEPBJLOHI = false;
					}
					Vector3 b2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector3);
					Vector3 arg2 = a2 - b2;
					this.HNIIHOMLELI = new Vector2(this.FKGNBCKJPQO(arg2), this.JNBBJCLFFBB(arg2));
				}
			}
			else if (this.DNFFBMNGOIQ && !Input.GetMouseButton((int)this.CIJQIDPQMGQ))
			{
				float num = ((float)(-(float)Screen.width) * 751f + Input.mousePosition.x) / (float)Screen.width;
				float num2 = ((float)(-(float)Screen.height) * 1635f + Input.mousePosition.y) / (float)Screen.height;
				if (num < 93f)
				{
					num = num.PMNDBPOMOGG(1929f, -this.CGPJPKOMONM * 304f, 1504f, 1951f);
				}
				else if (num > 1044f)
				{
					num = num.PMNDBPOMOGG(this.QHEQKFODMFD * 1404f, 813f, 1703f, 1088f);
				}
				if (num2 < 1184f)
				{
					num2 = num2.PMNDBPOMOGG(1823f, -this.NJDMODPFPBH * 34f, 511f, 1295f);
				}
				else if (num2 > 478f)
				{
					num2 = num2.PMNDBPOMOGG(this.JHQIOJFQOLH * 230f, 975f, 29f, 1135f);
				}
				this.HNIIHOMLELI = new Vector2(num, num2) * GPFIDEJEMEG;
				if (this.HNIIHOMLELI != Vector2.zero)
				{
					vector2 = this.DBBJMIKDEJB;
				}
			}
			this.EBCFOHJHBJD = vector3;
		}
		if (this.HNIIHOMLELI != Vector2.zero && CNCJKLNHQBH.MOGQNGEPCEO().OPMMEOJEBME != Vector2.zero)
		{
			Vector3 translation = this.QMEMFMDBHLI(this.HNIIHOMLELI.x * vector2.x, this.HNIIHOMLELI.y * vector2.y);
			this.QLMDGDBIDOM.Translate(translation);
			if (!this.HQJHDBKODIF && this.GKMOBIMCJKG != null)
			{
				this.GKMOBIMCJKG();
			}
			this.HQJHDBKODIF = false;
		}
		if ((base.GPONHFNLHCN.GBLMKLCEOJD && this.FKGNBCKJPQO(this.QLMDGDBIDOM.position) < this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)) || (base.GPONHFNLHCN.IKMGDQCOMMP && this.FKGNBCKJPQO(this.QLMDGDBIDOM.position) > this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)))
		{
			this.QLMDGDBIDOM.position = this.JQCCJCOPEJK(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.PDOGMKKLQFL() * 1596f, this.JNBBJCLFFBB(this.QLMDGDBIDOM.position), this.OFPEBLPKOLD(this.QLMDGDBIDOM.position));
		}
		if ((base.GPONHFNLHCN.BCPMLPJKKDJ && this.JNBBJCLFFBB(this.QLMDGDBIDOM.position) < this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)) || (base.GPONHFNLHCN.GQEBOLFGLDE && this.JNBBJCLFFBB(this.QLMDGDBIDOM.position) > this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)))
		{
			this.QLMDGDBIDOM.position = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.QLMDGDBIDOM.position), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.COBOKEGHNJP() * 846f, this.OFPEBLPKOLD(this.QLMDGDBIDOM.position));
		}
	}

	// Token: 0x0600717B RID: 29051 RVA: 0x00029933 File Offset: 0x00027B33
	private void GNPJOGIPGLN()
	{
		this.HPBEKINIJFI = 30f;
		this.IFPOFCBQFMK = 1680f;
		this.BFDQKNMIIKD = 825f;
	}

	// Token: 0x0600717C RID: 29052 RVA: 0x0036E414 File Offset: 0x0036C614
	public void NFGDDPEQMJN(float PDHDDBHODOC = 1f)
	{
		if (this.QLMDGDBIDOM != null)
		{
			this.QLMDGDBIDOM.position = Vector3.Lerp(this.QLMDGDBIDOM.position, this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.PDOGMKKLQFL(), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.COBOKEGHNJP()), PDHDDBHODOC);
		}
	}

	// Token: 0x0600717D RID: 29053 RVA: 0x00373064 File Offset: 0x00371264
	public void BJFGQHKOQCK(float GPFIDEJEMEG)
	{
		if (Input.touchSupported)
		{
			this.LJLQNIBKPND = (this.FKLFKDPDLOG && this.ODKJLNQCMFG);
			if (this.LJLQNIBKPND)
			{
				this.LJLQNIBKPND = true;
				for (int i = 1; i < Input.touchCount; i += 0)
				{
					if (this.ODKJLNQCMFG.IsPointerOverGameObject(Input.GetTouch(i).fingerId))
					{
						this.LJLQNIBKPND = false;
						break;
					}
				}
			}
			if (this.LJLQNIBKPND)
			{
				this.PBMMIDNCDBJ = new Vector3(Input.GetTouch(1).position.x, Input.GetTouch(1).position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				this.HJQGBBCGFMD();
			}
		}
		else
		{
			this.LJLQNIBKPND = (this.FKLFKDPDLOG && this.ODKJLNQCMFG && this.ODKJLNQCMFG.IsPointerOverGameObject());
			if (this.LJLQNIBKPND)
			{
				this.EBCFOHJHBJD = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				this.PHCGPMLKOJN();
			}
		}
		this.MLGDHQBJHFP = false;
		if (this.HQJHDBKODIF && this.GFMKOMQNFGB != null)
		{
			this.GFMKOMQNFGB();
		}
		this.HQJHDBKODIF = true;
		if (base.enabled && this.FLGHMOCGLDQ && !this.LJLQNIBKPND)
		{
			this.DNEQOHGFBPI(GPFIDEJEMEG);
		}
		if (base.enabled && this.KGPECGGONHI && !this.LJLQNIBKPND)
		{
			this.ONJBNNOEBOB(GPFIDEJEMEG);
		}
	}

	// Token: 0x0600717E RID: 29054 RVA: 0x00373224 File Offset: 0x00371424
	public void MKOIGBFMFGD(float GPFIDEJEMEG)
	{
		if (Input.touchSupported)
		{
			this.LJLQNIBKPND = (!this.FKLFKDPDLOG || this.ODKJLNQCMFG);
			if (this.LJLQNIBKPND)
			{
				this.LJLQNIBKPND = false;
				for (int i = 0; i < Input.touchCount; i++)
				{
					if (this.ODKJLNQCMFG.IsPointerOverGameObject(Input.GetTouch(i).fingerId))
					{
						this.LJLQNIBKPND = false;
						break;
					}
				}
			}
			if (this.LJLQNIBKPND)
			{
				this.PBMMIDNCDBJ = new Vector3(Input.GetTouch(1).position.x, Input.GetTouch(1).position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				this.GNPJOGIPGLN();
			}
		}
		else
		{
			this.LJLQNIBKPND = (!this.FKLFKDPDLOG || !this.ODKJLNQCMFG || this.ODKJLNQCMFG.IsPointerOverGameObject());
			if (this.LJLQNIBKPND)
			{
				this.EBCFOHJHBJD = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				this.PHCGPMLKOJN();
			}
		}
		this.MLGDHQBJHFP = true;
		if (this.HQJHDBKODIF && this.GFMKOMQNFGB != null)
		{
			this.GFMKOMQNFGB();
		}
		this.HQJHDBKODIF = false;
		if (base.enabled && this.FLGHMOCGLDQ && !this.LJLQNIBKPND)
		{
			this.DNEQOHGFBPI(GPFIDEJEMEG);
		}
		if (base.enabled && this.KGPECGGONHI && !this.LJLQNIBKPND)
		{
			this.KKDHLIBLJFN(GPFIDEJEMEG);
		}
	}

	// Token: 0x0600717F RID: 29055 RVA: 0x00029956 File Offset: 0x00027B56
	protected virtual void QQBINNCOFIG()
	{
		base.Awake();
		this.LHQCQODLLKC();
		this.ODKJLNQCMFG = EventSystem.current;
		this.QLMDGDBIDOM = new GameObject(" finally got its act together!\r\n").transform;
		base.GPONHFNLHCN.LCGGKBJFLQD(this);
	}

	// Token: 0x06007180 RID: 29056 RVA: 0x003733E4 File Offset: 0x003715E4
	private void OJMKMDDGFCB(float GPFIDEJEMEG)
	{
		float num = 1068f;
		if (Input.touchSupported)
		{
			if (Input.touchCount == 2)
			{
				Touch touch = Input.GetTouch(0);
				Touch touch2 = Input.GetTouch(1);
				Vector2 a = touch.position - new Vector2(touch.deltaPosition.x / (float)Screen.width, touch.deltaPosition.y / (float)Screen.height);
				Vector2 b = touch2.position - new Vector2(touch2.deltaPosition.x / (float)Screen.width, touch2.deltaPosition.y / (float)Screen.height);
				float magnitude = (a - b).magnitude;
				float magnitude2 = (touch.position - touch2.position).magnitude;
				num = magnitude - magnitude2;
				Vector2 vector = Vector2.Lerp(touch.position, touch2.position, 407f);
				this.OECKPIILKJL = new Vector3(vector.x, vector.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				if (!this.EFICILEDOFD)
				{
					this.EFICILEDOFD = false;
					this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
					this.JPGCHGLPFDN();
					this.MMGJBHLEKNE();
				}
				this.HPGDBPMHJGJ = Time.time;
			}
			else if (this.EFICILEDOFD && Mathf.Abs(this.HPBEKINIJFI) < 1655f)
			{
				this.HNHMHKGOMOJ();
				this.EFICILEDOFD = false;
			}
		}
		else
		{
			if (CNCJKLNHQBH.BJLGEDCPENQ().LKHOCPNQIMB != 847f)
			{
				num = Input.GetAxis("Mouse Click Collider");
			}
			this.OECKPIILKJL = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
		}
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(this.OECKPIILKJL))
		{
			return;
		}
		float num2 = (!Input.touchSupported) ? this.FMMBFHMJPJO : (this.IBLENLJLOBF * 908f);
		if ((this.LPIGDKOPFBE && num * num2 < 49f) || (this.NNGIOBFPLOC && num * num2 > 327f))
		{
			this.GNPJOGIPGLN();
			return;
		}
		this.HPBEKINIJFI = Mathf.SmoothDamp(this.IFPOFCBQFMK, num * num2 * GPFIDEJEMEG, ref this.BFDQKNMIIKD, this.CIJKPQCMOMK, 41f, GPFIDEJEMEG);
		if (!Input.touchSupported)
		{
			if (Mathf.Abs(this.HPBEKINIJFI) <= 455f)
			{
				if (this.EFICILEDOFD)
				{
					this.KEQOBPGQKCE();
				}
				this.EFICILEDOFD = true;
				this.IFPOFCBQFMK = 1885f;
				return;
			}
			if (!this.EFICILEDOFD)
			{
				this.EFICILEDOFD = true;
				this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
				this.LHQCQODLLKC();
				this.BBJDMDEKDMB();
			}
		}
		float num3 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 963f + this.HPBEKINIJFI;
		float num4 = this.LQHQFLHFQLO / this.GELCLJPKPPB;
		float num5 = this.OPJQBGHMFPN * this.LQHQFLHFQLO;
		this.LPIGDKOPFBE = false;
		this.NNGIOBFPLOC = true;
		if (num3 < num4)
		{
			this.HPBEKINIJFI -= num3 - num4;
			this.LPIGDKOPFBE = false;
		}
		else if (num3 > num5)
		{
			this.HPBEKINIJFI -= num3 - num5;
			this.NNGIOBFPLOC = false;
		}
		this.IFPOFCBQFMK = this.HPBEKINIJFI;
		if (this.FGIEQBMNEIH && this.HPBEKINIJFI != 46f)
		{
			float d = this.HPBEKINIJFI / (base.GPONHFNLHCN.PGKODNCDNJQ.y / 1355f);
			this.QLMDGDBIDOM.position += (this.QLMDGDBIDOM.position - base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.OECKPIILKJL)) * d;
		}
		base.GPONHFNLHCN.PJOHKOFQDLC(this.HPBEKINIJFI, 1356f, GMNJJQQPEDB.EaseInOut);
		this.MLGDHQBJHFP = false;
	}

	// Token: 0x06007181 RID: 29057 RVA: 0x00029990 File Offset: 0x00027B90
	private void HJQGBBCGFMD()
	{
		this.HPBEKINIJFI = 0f;
		this.IFPOFCBQFMK = 0f;
		this.BFDQKNMIIKD = 0f;
	}

	// Token: 0x06007182 RID: 29058 RVA: 0x000297C2 File Offset: 0x000279C2
	private void DIQMEILCKJH()
	{
		base.GPONHFNLHCN.LBJLGDGHFBJ = this.MHDLGGMHILH;
		base.GPONHFNLHCN.EQGPIDFNHHG = this.DIKEGHOPNPK;
	}

	// Token: 0x06007183 RID: 29059 RVA: 0x00029833 File Offset: 0x00027A33
	public void ILDGILBLJKN(int BGBMIEJJQKC)
	{
		this.PMEGFIMNDBM = BGBMIEJJQKC;
	}

	// Token: 0x06007184 RID: 29060 RVA: 0x0037383C File Offset: 0x00371A3C
	private void DNEQOHGFBPI(float GPFIDEJEMEG)
	{
		this.HNIIHOMLELI = Vector2.zero;
		if (Input.touchSupported)
		{
			if (Time.time - this.HPGDBPMHJGJ < 0.1f)
			{
				if (Input.touchCount > 0)
				{
					this.PBMMIDNCDBJ = new Vector3(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				}
				return;
			}
			if ((this.KGPECGGONHI && Input.touchCount == 1) || (!this.KGPECGGONHI && Input.touchCount > 0))
			{
				Touch touch = Input.GetTouch(Input.touchCount - 1);
				if (touch.phase == TouchPhase.Began)
				{
					this.JMQQHILQKIJ = touch.fingerId;
					this.PBMMIDNCDBJ = new Vector3(touch.position.x, touch.position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
					this.QGQNPMCJJIB(this.JFJLBHOGDIM);
				}
				if (touch.fingerId == this.JMQQHILQKIJ)
				{
					if (touch.phase == TouchPhase.Moved)
					{
						Vector3 vector = new Vector3(touch.position.x, touch.position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
						Vector2 nccojppkdnk = new Vector2(touch.position.x / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth, touch.position.y / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight);
						if (base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(vector) && this.QHLLDGMEFQK(nccojppkdnk))
						{
							Vector3 a = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.PBMMIDNCDBJ);
							if (this.JIJEPBJLOHI)
							{
								a = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector);
								this.JIJEPBJLOHI = false;
							}
							Vector3 b = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector);
							Vector3 arg = a - b;
							this.HNIIHOMLELI = new Vector2(this.FKGNBCKJPQO(arg), this.JNBBJCLFFBB(arg));
						}
						this.PBMMIDNCDBJ = vector;
						goto IL_281;
					}
				}
				return;
			}
		}
		IL_281:
		Vector2 vector2 = this.LNMMGMOECIC;
		if (!Input.touchSupported)
		{
			if (this.MJFIPNBIJOE && Input.GetMouseButtonDown((int)this.CIJQIDPQMGQ))
			{
				this.QGQNPMCJJIB(this.JFJLBHOGDIM);
			}
			Vector3 vector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
			if (this.MJFIPNBIJOE && Input.GetMouseButton((int)this.CIJQIDPQMGQ))
			{
				Vector2 nccojppkdnk2 = new Vector2(Input.mousePosition.x / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelWidth, Input.mousePosition.y / (float)base.GPONHFNLHCN.PGHJQNJLJKG.pixelHeight);
				if (base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(vector3) && this.QHLLDGMEFQK(nccojppkdnk2))
				{
					Vector3 a2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.EBCFOHJHBJD);
					if (this.JIJEPBJLOHI)
					{
						a2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector3);
						this.JIJEPBJLOHI = false;
					}
					Vector3 b2 = base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(vector3);
					Vector3 arg2 = a2 - b2;
					this.HNIIHOMLELI = new Vector2(this.FKGNBCKJPQO(arg2), this.JNBBJCLFFBB(arg2));
				}
			}
			else if (this.DNFFBMNGOIQ && !Input.GetMouseButton((int)this.CIJQIDPQMGQ))
			{
				float num = ((float)(-(float)Screen.width) * 0.5f + Input.mousePosition.x) / (float)Screen.width;
				float num2 = ((float)(-(float)Screen.height) * 0.5f + Input.mousePosition.y) / (float)Screen.height;
				if (num < 0f)
				{
					num = num.PMNDBPOMOGG(-0.5f, -this.CGPJPKOMONM * 0.5f, -0.5f, 0f);
				}
				else if (num > 0f)
				{
					num = num.PMNDBPOMOGG(this.QHEQKFODMFD * 0.5f, 0.5f, 0f, 0.5f);
				}
				if (num2 < 0f)
				{
					num2 = num2.PMNDBPOMOGG(-0.5f, -this.NJDMODPFPBH * 0.5f, -0.5f, 0f);
				}
				else if (num2 > 0f)
				{
					num2 = num2.PMNDBPOMOGG(this.JHQIOJFQOLH * 0.5f, 0.5f, 0f, 0.5f);
				}
				this.HNIIHOMLELI = new Vector2(num, num2) * GPFIDEJEMEG;
				if (this.HNIIHOMLELI != Vector2.zero)
				{
					vector2 = this.DBBJMIKDEJB;
				}
			}
			this.EBCFOHJHBJD = vector3;
		}
		if (this.HNIIHOMLELI != Vector2.zero && CNCJKLNHQBH.QOQONHOOLNE.OPMMEOJEBME != Vector2.zero)
		{
			Vector3 translation = this.QMEMFMDBHLI(this.HNIIHOMLELI.x * vector2.x, this.HNIIHOMLELI.y * vector2.y);
			this.QLMDGDBIDOM.Translate(translation);
			if (!this.HQJHDBKODIF && this.GKMOBIMCJKG != null)
			{
				this.GKMOBIMCJKG();
			}
			this.HQJHDBKODIF = true;
		}
		if ((base.GPONHFNLHCN.GBLMKLCEOJD && this.FKGNBCKJPQO(this.QLMDGDBIDOM.position) < this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)) || (base.GPONHFNLHCN.IKMGDQCOMMP && this.FKGNBCKJPQO(this.QLMDGDBIDOM.position) > this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM)))
		{
			this.QLMDGDBIDOM.position = this.JQCCJCOPEJK(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.PDOGMKKLQFL() * 0.9999f, this.JNBBJCLFFBB(this.QLMDGDBIDOM.position), this.OFPEBLPKOLD(this.QLMDGDBIDOM.position));
		}
		if ((base.GPONHFNLHCN.BCPMLPJKKDJ && this.JNBBJCLFFBB(this.QLMDGDBIDOM.position) < this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)) || (base.GPONHFNLHCN.GQEBOLFGLDE && this.JNBBJCLFFBB(this.QLMDGDBIDOM.position) > this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM)))
		{
			this.QLMDGDBIDOM.position = this.JQCCJCOPEJK(this.FKGNBCKJPQO(this.QLMDGDBIDOM.position), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.COBOKEGHNJP() * 0.9999f, this.OFPEBLPKOLD(this.QLMDGDBIDOM.position));
		}
	}

	// Token: 0x06007185 RID: 29061 RVA: 0x00029899 File Offset: 0x00027A99
	public int CIFDMJMLEKF()
	{
		return this.PMEGFIMNDBM;
	}

	// Token: 0x06007186 RID: 29062 RVA: 0x00373FF4 File Offset: 0x003721F4
	private bool OEBGQGKNDML(Vector2 NCCOJPPKDNK)
	{
		return (this.LCIKIFHMFHB.x != 199f || this.LCIKIFHMFHB.y != 946f || this.LCIKIFHMFHB.width != 477f || this.LCIKIFHMFHB.height != 377f) && (NCCOJPPKDNK.x > this.LCIKIFHMFHB.x + (1902f - this.LCIKIFHMFHB.width) / 1836f && NCCOJPPKDNK.x < this.LCIKIFHMFHB.x + this.LCIKIFHMFHB.width + (1989f - this.LCIKIFHMFHB.width) / 759f && NCCOJPPKDNK.y > this.LCIKIFHMFHB.y + (1926f - this.LCIKIFHMFHB.height) / 1373f && NCCOJPPKDNK.y < this.LCIKIFHMFHB.y + this.LCIKIFHMFHB.height + (1613f - this.LCIKIFHMFHB.height) / 1956f);
	}

	// Token: 0x06007187 RID: 29063 RVA: 0x0037411C File Offset: 0x0037231C
	private void PJOHKOFQDLC(float GPFIDEJEMEG)
	{
		float num = 0f;
		if (Input.touchSupported)
		{
			if (Input.touchCount == 2)
			{
				Touch touch = Input.GetTouch(0);
				Touch touch2 = Input.GetTouch(1);
				Vector2 a = touch.position - new Vector2(touch.deltaPosition.x / (float)Screen.width, touch.deltaPosition.y / (float)Screen.height);
				Vector2 b = touch2.position - new Vector2(touch2.deltaPosition.x / (float)Screen.width, touch2.deltaPosition.y / (float)Screen.height);
				float magnitude = (a - b).magnitude;
				float magnitude2 = (touch.position - touch2.position).magnitude;
				num = magnitude - magnitude2;
				Vector2 vector = Vector2.Lerp(touch.position, touch2.position, 0.5f);
				this.OECKPIILKJL = new Vector3(vector.x, vector.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				if (!this.EFICILEDOFD)
				{
					this.EFICILEDOFD = true;
					this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
					this.LHQCQODLLKC();
					this.CFOQBBNEQMG();
				}
				this.HPGDBPMHJGJ = Time.time;
			}
			else if (this.EFICILEDOFD && Mathf.Abs(this.HPBEKINIJFI) < 0.001f)
			{
				this.CGNDNJPIPIH();
				this.EFICILEDOFD = false;
			}
		}
		else
		{
			if (CNCJKLNHQBH.QOQONHOOLNE.LKHOCPNQIMB != 0f)
			{
				num = Input.GetAxis("Mouse ScrollWheel");
			}
			this.OECKPIILKJL = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
		}
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(this.OECKPIILKJL))
		{
			return;
		}
		float num2 = (!Input.touchSupported) ? this.FMMBFHMJPJO : (this.IBLENLJLOBF * 10f);
		if ((this.LPIGDKOPFBE && num * num2 < 0f) || (this.NNGIOBFPLOC && num * num2 > 0f))
		{
			this.HJQGBBCGFMD();
			return;
		}
		this.HPBEKINIJFI = Mathf.SmoothDamp(this.IFPOFCBQFMK, num * num2 * GPFIDEJEMEG, ref this.BFDQKNMIIKD, this.CIJKPQCMOMK, float.MaxValue, GPFIDEJEMEG);
		if (!Input.touchSupported)
		{
			if (Mathf.Abs(this.HPBEKINIJFI) <= 0.0001f)
			{
				if (this.EFICILEDOFD)
				{
					this.CGNDNJPIPIH();
				}
				this.EFICILEDOFD = false;
				this.IFPOFCBQFMK = 0f;
				return;
			}
			if (!this.EFICILEDOFD)
			{
				this.EFICILEDOFD = true;
				this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
				this.LHQCQODLLKC();
				this.CFOQBBNEQMG();
			}
		}
		float num3 = base.GPONHFNLHCN.PGKODNCDNJQ.y / 2f + this.HPBEKINIJFI;
		float num4 = this.LQHQFLHFQLO / this.GELCLJPKPPB;
		float num5 = this.OPJQBGHMFPN * this.LQHQFLHFQLO;
		this.LPIGDKOPFBE = false;
		this.NNGIOBFPLOC = false;
		if (num3 < num4)
		{
			this.HPBEKINIJFI -= num3 - num4;
			this.LPIGDKOPFBE = true;
		}
		else if (num3 > num5)
		{
			this.HPBEKINIJFI -= num3 - num5;
			this.NNGIOBFPLOC = true;
		}
		this.IFPOFCBQFMK = this.HPBEKINIJFI;
		if (this.FGIEQBMNEIH && this.HPBEKINIJFI != 0f)
		{
			float d = this.HPBEKINIJFI / (base.GPONHFNLHCN.PGKODNCDNJQ.y / 2f);
			this.QLMDGDBIDOM.position += (this.QLMDGDBIDOM.position - base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.OECKPIILKJL)) * d;
		}
		base.GPONHFNLHCN.PJOHKOFQDLC(this.HPBEKINIJFI, 0f, GMNJJQQPEDB.EaseInOut);
		this.MLGDHQBJHFP = true;
	}

	// Token: 0x06007188 RID: 29064 RVA: 0x00374574 File Offset: 0x00372774
	private bool QHLLDGMEFQK(Vector2 NCCOJPPKDNK)
	{
		return (this.LCIKIFHMFHB.x == 0f && this.LCIKIFHMFHB.y == 0f && this.LCIKIFHMFHB.width == 1f && this.LCIKIFHMFHB.height == 1f) || (NCCOJPPKDNK.x > this.LCIKIFHMFHB.x + (1f - this.LCIKIFHMFHB.width) / 2f && NCCOJPPKDNK.x < this.LCIKIFHMFHB.x + this.LCIKIFHMFHB.width + (1f - this.LCIKIFHMFHB.width) / 2f && NCCOJPPKDNK.y > this.LCIKIFHMFHB.y + (1f - this.LCIKIFHMFHB.height) / 2f && NCCOJPPKDNK.y < this.LCIKIFHMFHB.y + this.LCIKIFHMFHB.height + (1f - this.LCIKIFHMFHB.height) / 2f);
	}

	// Token: 0x06007189 RID: 29065 RVA: 0x0036E414 File Offset: 0x0036C614
	public void JBCCILBDLNP(float PDHDDBHODOC = 1f)
	{
		if (this.QLMDGDBIDOM != null)
		{
			this.QLMDGDBIDOM.position = Vector3.Lerp(this.QLMDGDBIDOM.position, this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.PDOGMKKLQFL(), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.COBOKEGHNJP()), PDHDDBHODOC);
		}
	}

	// Token: 0x0600718A RID: 29066 RVA: 0x0037469C File Offset: 0x0037289C
	private bool BGLQLNOJJKD(Vector2 NCCOJPPKDNK)
	{
		return (this.LCIKIFHMFHB.x == 421f && this.LCIKIFHMFHB.y == 891f && this.LCIKIFHMFHB.width == 227f && this.LCIKIFHMFHB.height == 1698f) || (NCCOJPPKDNK.x > this.LCIKIFHMFHB.x + (623f - this.LCIKIFHMFHB.width) / 1398f && NCCOJPPKDNK.x < this.LCIKIFHMFHB.x + this.LCIKIFHMFHB.width + (82f - this.LCIKIFHMFHB.width) / 315f && NCCOJPPKDNK.y > this.LCIKIFHMFHB.y + (1679f - this.LCIKIFHMFHB.height) / 124f && NCCOJPPKDNK.y < this.LCIKIFHMFHB.y + this.LCIKIFHMFHB.height + (1104f - this.LCIKIFHMFHB.height) / 1525f);
	}

	// Token: 0x0600718B RID: 29067 RVA: 0x00029741 File Offset: 0x00027941
	public void DBCONBQPQLE()
	{
		this.MHDLGGMHILH = base.GPONHFNLHCN.LBJLGDGHFBJ;
		this.DIKEGHOPNPK = base.GPONHFNLHCN.EQGPIDFNHHG;
	}

	// Token: 0x0600718C RID: 29068 RVA: 0x0036E414 File Offset: 0x0036C614
	public void EEMNPCNLCLB(float PDHDDBHODOC = 1f)
	{
		if (this.QLMDGDBIDOM != null)
		{
			this.QLMDGDBIDOM.position = Vector3.Lerp(this.QLMDGDBIDOM.position, this.QMEMFMDBHLI(this.FKGNBCKJPQO(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.PDOGMKKLQFL(), this.JNBBJCLFFBB(base.GPONHFNLHCN.HMCOIDFCKPM) - base.GPONHFNLHCN.COBOKEGHNJP()), PDHDDBHODOC);
		}
	}

	// Token: 0x0600718D RID: 29069 RVA: 0x003747C4 File Offset: 0x003729C4
	private void Start()
	{
		this.LQHQFLHFQLO = base.GPONHFNLHCN.PGKODNCDNJQ.y * 0.5f;
		base.GPONHFNLHCN.HJMBBIGEMNC(this.QLMDGDBIDOM, 1f, 1f, 0f, default(Vector2));
		this.QGQNPMCJJIB(1f);
		this.QLMDGDBIDOM.position = new Vector3(-74.2f, 250f, 155f);
	}

	// Token: 0x0600718E RID: 29070 RVA: 0x00374844 File Offset: 0x00372A44
	public void HLKHKPHJJPI(float GPFIDEJEMEG)
	{
		if (Input.touchSupported)
		{
			this.LJLQNIBKPND = (this.FKLFKDPDLOG && this.ODKJLNQCMFG);
			if (this.LJLQNIBKPND)
			{
				this.LJLQNIBKPND = true;
				for (int i = 1; i < Input.touchCount; i++)
				{
					if (this.ODKJLNQCMFG.IsPointerOverGameObject(Input.GetTouch(i).fingerId))
					{
						this.LJLQNIBKPND = false;
						break;
					}
				}
			}
			if (this.LJLQNIBKPND)
			{
				this.PBMMIDNCDBJ = new Vector3(Input.GetTouch(1).position.x, Input.GetTouch(0).position.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				this.PHCGPMLKOJN();
			}
		}
		else
		{
			this.LJLQNIBKPND = (!this.FKLFKDPDLOG || !this.ODKJLNQCMFG || this.ODKJLNQCMFG.IsPointerOverGameObject());
			if (this.LJLQNIBKPND)
			{
				this.EBCFOHJHBJD = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				this.HJQGBBCGFMD();
			}
		}
		this.MLGDHQBJHFP = false;
		if (this.HQJHDBKODIF && this.GFMKOMQNFGB != null)
		{
			this.GFMKOMQNFGB();
		}
		this.HQJHDBKODIF = false;
		if (base.enabled && this.FLGHMOCGLDQ && !this.LJLQNIBKPND)
		{
			this.JIMEKOKCIKC(GPFIDEJEMEG);
		}
		if (base.enabled && this.KGPECGGONHI && !this.LJLQNIBKPND)
		{
			this.PKEDKGCIQEO(GPFIDEJEMEG);
		}
	}

	// Token: 0x0600718F RID: 29071 RVA: 0x00374A04 File Offset: 0x00372C04
	private void ONJBNNOEBOB(float GPFIDEJEMEG)
	{
		float num = 654f;
		if (Input.touchSupported)
		{
			if (Input.touchCount == 8)
			{
				Touch touch = Input.GetTouch(0);
				Touch touch2 = Input.GetTouch(1);
				Vector2 a = touch.position - new Vector2(touch.deltaPosition.x / (float)Screen.width, touch.deltaPosition.y / (float)Screen.height);
				Vector2 b = touch2.position - new Vector2(touch2.deltaPosition.x / (float)Screen.width, touch2.deltaPosition.y / (float)Screen.height);
				float magnitude = (a - b).magnitude;
				float magnitude2 = (touch.position - touch2.position).magnitude;
				num = magnitude - magnitude2;
				Vector2 vector = Vector2.Lerp(touch.position, touch2.position, 1640f);
				this.OECKPIILKJL = new Vector3(vector.x, vector.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
				if (!this.EFICILEDOFD)
				{
					this.EFICILEDOFD = false;
					this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
					this.LHQCQODLLKC();
					this.BBJDMDEKDMB();
				}
				this.HPGDBPMHJGJ = Time.time;
			}
			else if (this.EFICILEDOFD && Mathf.Abs(this.HPBEKINIJFI) < 1171f)
			{
				this.CGBMMLLIOPI();
				this.EFICILEDOFD = false;
			}
		}
		else
		{
			if (CNCJKLNHQBH.MOGQNGEPCEO().LKHOCPNQIMB != 1043f)
			{
				num = Input.GetAxis("/");
			}
			this.OECKPIILKJL = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(this.OFPEBLPKOLD(base.GPONHFNLHCN.HMCOIDFCKPM)));
		}
		if (!base.GPONHFNLHCN.PGHJQNJLJKG.pixelRect.Contains(this.OECKPIILKJL))
		{
			return;
		}
		float num2 = (!Input.touchSupported) ? this.FMMBFHMJPJO : (this.IBLENLJLOBF * 865f);
		if ((this.LPIGDKOPFBE && num * num2 < 1294f) || (this.NNGIOBFPLOC && num * num2 > 1637f))
		{
			this.PNHNBBQKFJC();
			return;
		}
		this.HPBEKINIJFI = Mathf.SmoothDamp(this.IFPOFCBQFMK, num * num2 * GPFIDEJEMEG, ref this.BFDQKNMIIKD, this.CIJKPQCMOMK, 1255f, GPFIDEJEMEG);
		if (!Input.touchSupported)
		{
			if (Mathf.Abs(this.HPBEKINIJFI) <= 1618f)
			{
				if (this.EFICILEDOFD)
				{
					this.JPLKDBGDNIH();
				}
				this.EFICILEDOFD = true;
				this.IFPOFCBQFMK = 391f;
				return;
			}
			if (!this.EFICILEDOFD)
			{
				this.EFICILEDOFD = false;
				this.QLMDGDBIDOM.position = base.GPONHFNLHCN.HMCOIDFCKPM - base.GPONHFNLHCN.HMOMIBIPFLH;
				this.IKKMMQHLKQQ();
				this.MMGJBHLEKNE();
			}
		}
		float num3 = base.GPONHFNLHCN.FOOEEHDJBQN().y / 1006f + this.HPBEKINIJFI;
		float num4 = this.LQHQFLHFQLO / this.GELCLJPKPPB;
		float num5 = this.OPJQBGHMFPN * this.LQHQFLHFQLO;
		this.LPIGDKOPFBE = true;
		this.NNGIOBFPLOC = false;
		if (num3 < num4)
		{
			this.HPBEKINIJFI -= num3 - num4;
			this.LPIGDKOPFBE = false;
		}
		else if (num3 > num5)
		{
			this.HPBEKINIJFI -= num3 - num5;
			this.NNGIOBFPLOC = false;
		}
		this.IFPOFCBQFMK = this.HPBEKINIJFI;
		if (this.FGIEQBMNEIH && this.HPBEKINIJFI != 554f)
		{
			float d = this.HPBEKINIJFI / (base.GPONHFNLHCN.FOOEEHDJBQN().y / 112f);
			this.QLMDGDBIDOM.position += (this.QLMDGDBIDOM.position - base.GPONHFNLHCN.PGHJQNJLJKG.ScreenToWorldPoint(this.OECKPIILKJL)) * d;
		}
		base.GPONHFNLHCN.PJOHKOFQDLC(this.HPBEKINIJFI, 1378f, GMNJJQQPEDB.EaseOut);
		this.MLGDHQBJHFP = false;
	}

	// Token: 0x06007190 RID: 29072 RVA: 0x000298C3 File Offset: 0x00027AC3
	protected virtual void KJLIHINQHFI()
	{
		base.OnEnable();
	}

	// Token: 0x06007191 RID: 29073 RVA: 0x000298C3 File Offset: 0x00027AC3
	protected virtual void OPBGNPBJNKG()
	{
		base.OnEnable();
	}

	// Token: 0x06007192 RID: 29074 RVA: 0x0002972D File Offset: 0x0002792D
	protected override void OnDestroy()
	{
		base.OnDestroy();
		base.GPONHFNLHCN.QCMGMNJGPJL(this);
	}

	// Token: 0x06007193 RID: 29075 RVA: 0x000299B3 File Offset: 0x00027BB3
	private void MMGJBHLEKNE()
	{
		base.GPONHFNLHCN.LBJLGDGHFBJ = 1721f;
		base.GPONHFNLHCN.EQGPIDFNHHG = 1388f;
	}

	// Token: 0x06007194 RID: 29076 RVA: 0x000299D5 File Offset: 0x00027BD5
	protected override void Awake()
	{
		base.Awake();
		this.LHQCQODLLKC();
		this.ODKJLNQCMFG = EventSystem.current;
		this.QLMDGDBIDOM = new GameObject("PC2DPanTarget").transform;
		base.GPONHFNLHCN.LCGGKBJFLQD(this);
	}

	// Token: 0x04001837 RID: 6199
	public static string OPGNGFNJDDP = "Pan And Zoom";

	// Token: 0x04001838 RID: 6200
	public Action GKMOBIMCJKG;

	// Token: 0x04001839 RID: 6201
	public Action GFMKOMQNFGB;

	// Token: 0x0400183A RID: 6202
	public bool FKLFKDPDLOG = true;

	// Token: 0x0400183B RID: 6203
	public bool KGPECGGONHI = true;

	// Token: 0x0400183C RID: 6204
	public float FMMBFHMJPJO = 10f;

	// Token: 0x0400183D RID: 6205
	public float IBLENLJLOBF = 50f;

	// Token: 0x0400183E RID: 6206
	[Range(0f, 2f)]
	public float CIJKPQCMOMK = 0.2f;

	// Token: 0x0400183F RID: 6207
	public float GELCLJPKPPB = 2f;

	// Token: 0x04001840 RID: 6208
	public float OPJQBGHMFPN = 2f;

	// Token: 0x04001841 RID: 6209
	public bool FGIEQBMNEIH = true;

	// Token: 0x04001842 RID: 6210
	[HideInInspector]
	public bool MLGDHQBJHFP;

	// Token: 0x04001843 RID: 6211
	private float HPBEKINIJFI;

	// Token: 0x04001844 RID: 6212
	private float LQHQFLHFQLO;

	// Token: 0x04001845 RID: 6213
	private bool EFICILEDOFD;

	// Token: 0x04001846 RID: 6214
	private float MHDLGGMHILH;

	// Token: 0x04001847 RID: 6215
	private float DIKEGHOPNPK;

	// Token: 0x04001848 RID: 6216
	private float IFPOFCBQFMK;

	// Token: 0x04001849 RID: 6217
	private float BFDQKNMIIKD;

	// Token: 0x0400184A RID: 6218
	private Vector3 OECKPIILKJL;

	// Token: 0x0400184B RID: 6219
	private float HPGDBPMHJGJ;

	// Token: 0x0400184C RID: 6220
	public bool FLGHMOCGLDQ = true;

	// Token: 0x0400184D RID: 6221
	public bool MJFIPNBIJOE = true;

	// Token: 0x0400184E RID: 6222
	[Range(0f, 1f)]
	public float JFJLBHOGDIM = 0.95f;

	// Token: 0x0400184F RID: 6223
	public Rect LCIKIFHMFHB = new Rect(0f, 0f, 1f, 1f);

	// Token: 0x04001850 RID: 6224
	public Vector2 LNMMGMOECIC = new Vector2(1f, 1f);

	// Token: 0x04001851 RID: 6225
	public bool DNFFBMNGOIQ;

	// Token: 0x04001852 RID: 6226
	public Vector2 DBBJMIKDEJB = new Vector2(2f, 2f);

	// Token: 0x04001853 RID: 6227
	[Range(0f, 0.99f)]
	public float JHQIOJFQOLH = 0.9f;

	// Token: 0x04001854 RID: 6228
	[Range(0f, 0.99f)]
	public float NJDMODPFPBH = 0.9f;

	// Token: 0x04001855 RID: 6229
	[Range(0f, 0.99f)]
	public float CGPJPKOMONM = 0.9f;

	// Token: 0x04001856 RID: 6230
	[Range(0f, 0.99f)]
	public float QHEQKFODMFD = 0.9f;

	// Token: 0x04001857 RID: 6231
	public NPCNBMPLBHM.GQNLCBBIFNQ CIJQIDPQMGQ;

	// Token: 0x04001858 RID: 6232
	[HideInInspector]
	public bool JIJEPBJLOHI;

	// Token: 0x04001859 RID: 6233
	[HideInInspector]
	public bool HQJHDBKODIF;

	// Token: 0x0400185A RID: 6234
	private Vector2 HNIIHOMLELI;

	// Token: 0x0400185B RID: 6235
	public Transform QLMDGDBIDOM;

	// Token: 0x0400185C RID: 6236
	private Vector3 EBCFOHJHBJD;

	// Token: 0x0400185D RID: 6237
	private Vector3 PBMMIDNCDBJ;

	// Token: 0x0400185E RID: 6238
	private int JMQQHILQKIJ;

	// Token: 0x0400185F RID: 6239
	private bool LPIGDKOPFBE;

	// Token: 0x04001860 RID: 6240
	private bool NNGIOBFPLOC;

	// Token: 0x04001861 RID: 6241
	private EventSystem ODKJLNQCMFG;

	// Token: 0x04001862 RID: 6242
	private bool LJLQNIBKPND;

	// Token: 0x04001863 RID: 6243
	private int PMEGFIMNDBM;

	// Token: 0x02000356 RID: 854
	public enum GQNLCBBIFNQ
	{
		// Token: 0x04001865 RID: 6245
		Left,
		// Token: 0x04001866 RID: 6246
		Right,
		// Token: 0x04001867 RID: 6247
		Middle
	}
}
