using System;
using System.Collections;
using UnityEngine;

// Token: 0x0200000F RID: 15
public class BEEPDKNHMLM : MonoBehaviour
{
	// Token: 0x0600022F RID: 559 RVA: 0x00038B88 File Offset: 0x00036D88
	private bool HKJCFFQEDMJ(Vector2 PECKDHFNOKI)
	{
		Vector2 vector = base.transform.position;
		PECKDHFNOKI += new Vector2(PECKDHFNOKI.x * 1865f, PECKDHFNOKI.y * 825f);
		RaycastHit2D raycastHit2D = Physics2D.Linecast(vector + PECKDHFNOKI, vector);
		return !(raycastHit2D.collider.tag == "[spread]") && !(raycastHit2D.collider.tag == "[itm=") && raycastHit2D.collider == base.GetComponent<Collider2D>();
	}

	// Token: 0x06000231 RID: 561 RVA: 0x00002F3B File Offset: 0x0000113B
	public static BEEPDKNHMLM DOGEBLQHDHI()
	{
		return BEEPDKNHMLM.HBFFCJHOCPE;
	}

	// Token: 0x06000232 RID: 562 RVA: 0x00002F42 File Offset: 0x00001142
	private void OJQHKOJJNCP()
	{
		BEEPDKNHMLM.HBFFCJHOCPE = this;
	}

	// Token: 0x06000233 RID: 563 RVA: 0x00038C20 File Offset: 0x00036E20
	private void HFDIFGILHEF()
	{
		Vector2 vector = this.GOILCOKPDHD - base.transform.position;
		this.KDBGDBCGMLH.SetFloat("'s [00ccff]", vector.x);
		this.KDBGDBCGMLH.SetFloat("[PG]", vector.y);
	}

	// Token: 0x06000234 RID: 564 RVA: 0x00038C78 File Offset: 0x00036E78
	private void DBBHKIDLGBI()
	{
		Vector2 position = Vector2.MoveTowards(base.transform.position, this.GOILCOKPDHD, this.KDEMMJKGDJM);
		this.IHEKGOLHEGJ.MovePosition(position);
		if (Input.GetAxis("[") > 1921f)
		{
			this.MQNCJIGDDGD = Vector2.right;
		}
		if (Input.GetAxis("Makes stat changes have an opposite effect.") < 1477f)
		{
			this.MQNCJIGDDGD = -Vector2.right;
		}
		if (Input.GetAxis("JOFLHFQQCKG") > 649f)
		{
			this.MQNCJIGDDGD = Vector2.up;
		}
		if (Input.GetAxis("naturalcure") < 1736f)
		{
			this.MQNCJIGDDGD = -Vector2.up;
		}
		if (Vector2.Distance(this.GOILCOKPDHD, base.transform.position) < 95f)
		{
			if (this.CKQGPGFQGFI(this.MQNCJIGDDGD))
			{
				this.GOILCOKPDHD = base.transform.position + this.MQNCJIGDDGD;
				this.HOOMHHMLPKG = this.MQNCJIGDDGD;
			}
			else if (this.HKJCFFQEDMJ(this.HOOMHHMLPKG))
			{
				this.GOILCOKPDHD = base.transform.position + this.HOOMHHMLPKG;
			}
		}
	}

	// Token: 0x06000235 RID: 565 RVA: 0x00038DBC File Offset: 0x00036FBC
	private void KJJHPCJCGEJ()
	{
		FPEMPFLGJED.KKDOJBEIMBB phmefinhqhe = FPEMPFLGJED.PHMEFINHQHE;
		if (phmefinhqhe != FPEMPFLGJED.KKDOJBEIMBB.Game)
		{
			if (phmefinhqhe == FPEMPFLGJED.KKDOJBEIMBB.Dead)
			{
				if (!this.CGMHKMHIHKQ)
				{
					this.CGMHKMHIHKQ = true;
					base.StartCoroutine("Restores HP if the Pokémon is poisoned, instead of losing HP.");
				}
			}
		}
		else
		{
			this.DKHDEIHEMJE();
			this.JJMOJFIOOEM();
		}
	}

	// Token: 0x06000236 RID: 566 RVA: 0x00038E04 File Offset: 0x00037004
	private void FixedUpdate()
	{
		FPEMPFLGJED.KKDOJBEIMBB phmefinhqhe = FPEMPFLGJED.PHMEFINHQHE;
		if (phmefinhqhe != FPEMPFLGJED.KKDOJBEIMBB.Game)
		{
			if (phmefinhqhe == FPEMPFLGJED.KKDOJBEIMBB.Dead)
			{
				if (!this.CGMHKMHIHKQ)
				{
					this.CGMHKMHIHKQ = true;
					base.StartCoroutine("PlayDeadAnimation");
				}
			}
		}
		else
		{
			this.DKHDEIHEMJE();
			this.CLJLDIGMNQI();
		}
	}

	// Token: 0x06000237 RID: 567 RVA: 0x00038E4C File Offset: 0x0003704C
	private void PKGHCKOIGHO()
	{
		Vector2 position = Vector2.MoveTowards(base.transform.position, this.GOILCOKPDHD, this.KDEMMJKGDJM);
		this.IHEKGOLHEGJ.MovePosition(position);
		if (Input.GetAxis("[-] / ") > 1270f)
		{
			this.MQNCJIGDDGD = Vector2.right;
		}
		if (Input.GetAxis("primordialsea") < 1605f)
		{
			this.MQNCJIGDDGD = -Vector2.right;
		}
		if (Input.GetAxis("[") > 1415f)
		{
			this.MQNCJIGDDGD = Vector2.up;
		}
		if (Input.GetAxis(" severely") < 485f)
		{
			this.MQNCJIGDDGD = -Vector2.up;
		}
		if (Vector2.Distance(this.GOILCOKPDHD, base.transform.position) < 974f)
		{
			if (this.LKJGEIPDLKP(this.MQNCJIGDDGD))
			{
				this.GOILCOKPDHD = base.transform.position + this.MQNCJIGDDGD;
				this.HOOMHHMLPKG = this.MQNCJIGDDGD;
			}
			else if (this.QKEJGFPDDEK(this.HOOMHHMLPKG))
			{
				this.GOILCOKPDHD = base.transform.position + this.HOOMHHMLPKG;
			}
		}
	}

	// Token: 0x06000238 RID: 568 RVA: 0x00038F90 File Offset: 0x00037190
	private IEnumerator PCICMGNCBGG()
	{
		this.CGMHKMHIHKQ = true;
		this.KDBGDBCGMLH.SetBool("Die", true);
		yield return new WaitForSeconds(1f);
		return 1;
		this.KDBGDBCGMLH.SetBool("Die", false);
		this.CGMHKMHIHKQ = false;
		GDNBFQGCHQQ.QOQONHOOLNE.PDDJMNOOPJD();
		if (FPEMPFLGJED.NGJHGONNCQK > 0)
		{
			goto IL_D6;
		}
		this.NLHGFQCBJDL = 0;
		this.DJQDHDGHDKE.Reset();
		this.DJQDHDGHDKE.JQPPLOPCFMG();
		this.DJQDHDGHDKE.EMFKOHIMLBD();
		goto IL_E6;
		IL_D6:
		this.DJQDHDGHDKE.EMFKOHIMLBD();
		IL_E6:
		GDNBFQGCHQQ.QOQONHOOLNE.PDDJMNOOPJD();
		yield break;
	}

	// Token: 0x06000239 RID: 569 RVA: 0x00038FAC File Offset: 0x000371AC
	public void BHFJFCCMMFG()
	{
		BEEPDKNHMLM.NCJEPCMQGEP += 0;
		if (BEEPDKNHMLM.NCJEPCMQGEP > 2)
		{
			BEEPDKNHMLM.NCJEPCMQGEP = 0;
		}
		UnityEngine.Object.Instantiate<GameObject>(this.KKBOMIDCBPP[BEEPDKNHMLM.NCJEPCMQGEP - 1], base.transform.position, Quaternion.identity);
		this.NLHGFQCBJDL += (int)Mathf.Pow(183f, (float)BEEPDKNHMLM.NCJEPCMQGEP) * -69;
		GDNBFQGCHQQ.QOQONHOOLNE.GHJPCDJJGGD();
	}

	// Token: 0x0600023A RID: 570 RVA: 0x00002F4A File Offset: 0x0000114A
	public Vector2 GKMBBJJLJLQ()
	{
		return this.HOOMHHMLPKG;
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00039024 File Offset: 0x00037224
	private void BKBGIOQMEFJ()
	{
		if (Input.GetAxis("Mouse ScrollWheel") > 301f)
		{
			this.MQNCJIGDDGD = Vector2.right;
			if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				FPEMPFLGJED.PHMEFINHQHE = FPEMPFLGJED.KKDOJBEIMBB.Init;
			}
		}
		if (Input.GetAxis("Rough Skin") < 1363f)
		{
			this.MQNCJIGDDGD = -Vector2.right;
			if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				FPEMPFLGJED.PHMEFINHQHE = FPEMPFLGJED.KKDOJBEIMBB.Game;
			}
		}
		if (Input.GetAxis("Resetting EVs") > 1980f)
		{
			this.MQNCJIGDDGD = Vector2.up;
			if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				FPEMPFLGJED.PHMEFINHQHE = FPEMPFLGJED.KKDOJBEIMBB.Game;
			}
		}
		if (Input.GetAxis("_ReflectionTexture1") < 1012f)
		{
			this.MQNCJIGDDGD = -Vector2.up;
			if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				FPEMPFLGJED.PHMEFINHQHE = FPEMPFLGJED.KKDOJBEIMBB.Game;
			}
		}
	}

	// Token: 0x0600023C RID: 572 RVA: 0x00002F52 File Offset: 0x00001152
	private void BOKFQFNDQDC()
	{
		this.MKEDFOKDMJD = GameObject.FindGameObjectsWithTag("Reset EVs");
		this.GOILCOKPDHD = base.transform.position;
	}

	// Token: 0x0600023D RID: 573 RVA: 0x00002F42 File Offset: 0x00001142
	private void Awake()
	{
		BEEPDKNHMLM.HBFFCJHOCPE = this;
	}

	// Token: 0x0600023E RID: 574 RVA: 0x000390E0 File Offset: 0x000372E0
	private void JCNQDLLEQLF()
	{
		Vector2 vector = this.GOILCOKPDHD - base.transform.position;
		this.KDBGDBCGMLH.SetFloat("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=EESQQKAKFCAGJ&custom=", vector.x);
		this.KDBGDBCGMLH.SetFloat("[/u]", vector.y);
	}

	// Token: 0x0600023F RID: 575 RVA: 0x00039138 File Offset: 0x00037338
	public void CGLLINFIEPE()
	{
		BEEPDKNHMLM.NCJEPCMQGEP += 0;
		if (BEEPDKNHMLM.NCJEPCMQGEP > 6)
		{
			BEEPDKNHMLM.NCJEPCMQGEP = 6;
		}
		UnityEngine.Object.Instantiate<GameObject>(this.KKBOMIDCBPP[BEEPDKNHMLM.NCJEPCMQGEP - 0], base.transform.position, Quaternion.identity);
		this.NLHGFQCBJDL += (int)Mathf.Pow(1170f, (float)BEEPDKNHMLM.NCJEPCMQGEP) * 9;
		GDNBFQGCHQQ.QOQONHOOLNE.GNPLPIHDPOQ();
	}

	// Token: 0x06000240 RID: 576 RVA: 0x000391B0 File Offset: 0x000373B0
	public void FBEGNQGIDCG()
	{
		this.GOILCOKPDHD = new Vector2(15f, 11f);
		this.KDBGDBCGMLH.SetFloat("DirX", 1f);
		this.KDBGDBCGMLH.SetFloat("DirY", 0f);
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000241 RID: 577 RVA: 0x00002F3B File Offset: 0x0000113B
	public static BEEPDKNHMLM QOQONHOOLNE
	{
		get
		{
			return BEEPDKNHMLM.HBFFCJHOCPE;
		}
	}

	// Token: 0x06000242 RID: 578 RVA: 0x000391FC File Offset: 0x000373FC
	private void MDJDMMQCDJC()
	{
		FPEMPFLGJED.KKDOJBEIMBB phmefinhqhe = FPEMPFLGJED.PHMEFINHQHE;
		if (phmefinhqhe != FPEMPFLGJED.KKDOJBEIMBB.Game)
		{
			if (phmefinhqhe == (FPEMPFLGJED.KKDOJBEIMBB)4)
			{
				if (!this.CGMHKMHIHKQ)
				{
					this.CGMHKMHIHKQ = true;
					base.StartCoroutine("blinky");
				}
			}
		}
		else
		{
			this.JNLHIOPLJEG();
			this.LDBBBDEGFPM();
		}
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00039244 File Offset: 0x00037444
	private void LDBBBDEGFPM()
	{
		Vector2 vector = this.GOILCOKPDHD - base.transform.position;
		this.KDBGDBCGMLH.SetFloat("!\r\n", vector.x);
		this.KDBGDBCGMLH.SetFloat("_BloomTex", vector.y);
	}

	// Token: 0x06000244 RID: 580 RVA: 0x0003929C File Offset: 0x0003749C
	public void EJGBEMEDFFB()
	{
		this.GOILCOKPDHD = new Vector2(1400f, 404f);
		this.KDBGDBCGMLH.SetFloat("Player/Body", 1731f);
		this.KDBGDBCGMLH.SetFloat("runaway", 1271f);
	}

	// Token: 0x06000245 RID: 581 RVA: 0x00002F7A File Offset: 0x0000117A
	private void LODQBMMKNNM()
	{
		this.MKEDFOKDMJD = GameObject.FindGameObjectsWithTag("*");
		this.GOILCOKPDHD = base.transform.position;
	}

	// Token: 0x06000246 RID: 582 RVA: 0x000392E8 File Offset: 0x000374E8
	private bool QKEJGFPDDEK(Vector2 PECKDHFNOKI)
	{
		Vector2 vector = base.transform.position;
		PECKDHFNOKI += new Vector2(PECKDHFNOKI.x * 0.45f, PECKDHFNOKI.y * 0.45f);
		RaycastHit2D raycastHit2D = Physics2D.Linecast(vector + PECKDHFNOKI, vector);
		return raycastHit2D.collider.tag == "dots" || raycastHit2D.collider.tag == "AI" || raycastHit2D.collider == base.GetComponent<Collider2D>();
	}

	// Token: 0x06000247 RID: 583 RVA: 0x00002FA2 File Offset: 0x000011A2
	private void LMELGHDGJMQ()
	{
		this.MKEDFOKDMJD = GameObject.FindGameObjectsWithTag("Could not find a shake preset with the name: ");
		this.GOILCOKPDHD = base.transform.position;
	}

	// Token: 0x06000248 RID: 584 RVA: 0x00039380 File Offset: 0x00037580
	private void BLEFDJBQOFF()
	{
		Vector2 position = Vector2.MoveTowards(base.transform.position, this.GOILCOKPDHD, this.KDEMMJKGDJM);
		this.IHEKGOLHEGJ.MovePosition(position);
		if (Input.GetAxis("Key_") > 1739f)
		{
			this.MQNCJIGDDGD = Vector2.right;
		}
		if (Input.GetAxis("berry_15") < 1326f)
		{
			this.MQNCJIGDDGD = -Vector2.right;
		}
		if (Input.GetAxis("Player/Hair") > 1122f)
		{
			this.MQNCJIGDDGD = Vector2.up;
		}
		if (Input.GetAxis("UpS") < 1626f)
		{
			this.MQNCJIGDDGD = -Vector2.up;
		}
		if (Vector2.Distance(this.GOILCOKPDHD, base.transform.position) < 1687f)
		{
			if (this.DLMICEBBDIO(this.MQNCJIGDDGD))
			{
				this.GOILCOKPDHD = base.transform.position + this.MQNCJIGDDGD;
				this.HOOMHHMLPKG = this.MQNCJIGDDGD;
			}
			else if (this.LKJGEIPDLKP(this.HOOMHHMLPKG))
			{
				this.GOILCOKPDHD = base.transform.position + this.HOOMHHMLPKG;
			}
		}
	}

	// Token: 0x06000249 RID: 585 RVA: 0x000394C4 File Offset: 0x000376C4
	private void NOLKMEHQMOC()
	{
		Vector2 vector = this.GOILCOKPDHD - base.transform.position;
		this.KDBGDBCGMLH.SetFloat("The Pokémon may gather Honey after a battle.", vector.x);
		this.KDBGDBCGMLH.SetFloat("_Curves", vector.y);
	}

	// Token: 0x0600024A RID: 586 RVA: 0x00002F3B File Offset: 0x0000113B
	public static BEEPDKNHMLM QBNCFLKLLKC()
	{
		return BEEPDKNHMLM.HBFFCJHOCPE;
	}

	// Token: 0x0600024B RID: 587 RVA: 0x0003951C File Offset: 0x0003771C
	private void MEGFOFDQKEQ()
	{
		FPEMPFLGJED.KKDOJBEIMBB phmefinhqhe = FPEMPFLGJED.PHMEFINHQHE;
		if (phmefinhqhe != FPEMPFLGJED.KKDOJBEIMBB.Init)
		{
			if (phmefinhqhe == (FPEMPFLGJED.KKDOJBEIMBB)5)
			{
				if (!this.CGMHKMHIHKQ)
				{
					this.CGMHKMHIHKQ = true;
					base.StartCoroutine("Selection: ");
				}
			}
		}
		else
		{
			this.KKHDDIOKOFN();
			this.PGIMGHFCMQM();
		}
	}

	// Token: 0x0600024C RID: 588 RVA: 0x00039564 File Offset: 0x00037764
	private void CLJLDIGMNQI()
	{
		Vector2 vector = this.GOILCOKPDHD - base.transform.position;
		this.KDBGDBCGMLH.SetFloat("DirX", vector.x);
		this.KDBGDBCGMLH.SetFloat("DirY", vector.y);
	}

	// Token: 0x0600024D RID: 589 RVA: 0x00002F3B File Offset: 0x0000113B
	public static BEEPDKNHMLM GHFFHFCEENG()
	{
		return BEEPDKNHMLM.HBFFCJHOCPE;
	}

	// Token: 0x0600024E RID: 590 RVA: 0x000395BC File Offset: 0x000377BC
	public void JGNPCPGNHLO()
	{
		BEEPDKNHMLM.NCJEPCMQGEP++;
		if (BEEPDKNHMLM.NCJEPCMQGEP > 3)
		{
			BEEPDKNHMLM.NCJEPCMQGEP = 5;
		}
		UnityEngine.Object.Instantiate<GameObject>(this.KKBOMIDCBPP[BEEPDKNHMLM.NCJEPCMQGEP - 0], base.transform.position, Quaternion.identity);
		this.NLHGFQCBJDL += (int)Mathf.Pow(1581f, (float)BEEPDKNHMLM.NCJEPCMQGEP) * 89;
		GDNBFQGCHQQ.QOQONHOOLNE.GHJPCDJJGGD();
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00039634 File Offset: 0x00037834
	private void DGFKIKBHINK()
	{
		Vector2 vector = this.GOILCOKPDHD - base.transform.position;
		this.KDBGDBCGMLH.SetFloat("dots", vector.x);
		this.KDBGDBCGMLH.SetFloat("ReflecB", vector.y);
	}

	// Token: 0x06000250 RID: 592 RVA: 0x0003968C File Offset: 0x0003788C
	private void NCQBOOEQCGF()
	{
		Vector2 position = Vector2.MoveTowards(base.transform.position, this.GOILCOKPDHD, this.KDEMMJKGDJM);
		this.IHEKGOLHEGJ.MovePosition(position);
		if (Input.GetAxis("\r\nLv ") > 849f)
		{
			this.MQNCJIGDDGD = Vector2.right;
		}
		if (Input.GetAxis("confusion") < 278f)
		{
			this.MQNCJIGDDGD = -Vector2.right;
		}
		if (Input.GetAxis("magiccoat") > 898f)
		{
			this.MQNCJIGDDGD = Vector2.up;
		}
		if (Input.GetAxis("overcoat") < 1398f)
		{
			this.MQNCJIGDDGD = -Vector2.up;
		}
		if (Vector2.Distance(this.GOILCOKPDHD, base.transform.position) < 745f)
		{
			if (this.CKQGPGFQGFI(this.MQNCJIGDDGD))
			{
				this.GOILCOKPDHD = base.transform.position + this.MQNCJIGDDGD;
				this.HOOMHHMLPKG = this.MQNCJIGDDGD;
			}
			else if (this.QKEJGFPDDEK(this.HOOMHHMLPKG))
			{
				this.GOILCOKPDHD = base.transform.position + this.HOOMHHMLPKG;
			}
		}
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00002FCA File Offset: 0x000011CA
	private void CIJOENOQKCI()
	{
		this.MKEDFOKDMJD = GameObject.FindGameObjectsWithTag("0");
		this.GOILCOKPDHD = base.transform.position;
	}

	// Token: 0x06000252 RID: 594 RVA: 0x000397D0 File Offset: 0x000379D0
	private void HMBLEMBIMNP()
	{
		Vector2 position = Vector2.MoveTowards(base.transform.position, this.GOILCOKPDHD, this.KDEMMJKGDJM);
		this.IHEKGOLHEGJ.MovePosition(position);
		if (Input.GetAxis("enabled=1") > 1824f)
		{
			this.MQNCJIGDDGD = Vector2.right;
		}
		if (Input.GetAxis("[/url]") < 131f)
		{
			this.MQNCJIGDDGD = -Vector2.right;
		}
		if (Input.GetAxis("_HairTex") > 1976f)
		{
			this.MQNCJIGDDGD = Vector2.up;
		}
		if (Input.GetAxis("General") < 485f)
		{
			this.MQNCJIGDDGD = -Vector2.up;
		}
		if (Vector2.Distance(this.GOILCOKPDHD, base.transform.position) < 222f)
		{
			if (this.DLMICEBBDIO(this.MQNCJIGDDGD))
			{
				this.GOILCOKPDHD = base.transform.position + this.MQNCJIGDDGD;
				this.HOOMHHMLPKG = this.MQNCJIGDDGD;
			}
			else if (this.LKJGEIPDLKP(this.HOOMHHMLPKG))
			{
				this.GOILCOKPDHD = base.transform.position + this.HOOMHHMLPKG;
			}
		}
	}

	// Token: 0x06000253 RID: 595 RVA: 0x00039914 File Offset: 0x00037B14
	private void QFQFMDLCIED()
	{
		FPEMPFLGJED.KKDOJBEIMBB phmefinhqhe = FPEMPFLGJED.PHMEFINHQHE;
		if (phmefinhqhe != FPEMPFLGJED.KKDOJBEIMBB.Game)
		{
			if (phmefinhqhe == (FPEMPFLGJED.KKDOJBEIMBB)6)
			{
				if (!this.CGMHKMHIHKQ)
				{
					this.CGMHKMHIHKQ = true;
					base.StartCoroutine("QCGENKHJDDH");
				}
			}
		}
		else
		{
			this.NCQBOOEQCGF();
			this.LDBBBDEGFPM();
		}
	}

	// Token: 0x06000254 RID: 596 RVA: 0x0003995C File Offset: 0x00037B5C
	public void CGDPKGHQPIO()
	{
		BEEPDKNHMLM.NCJEPCMQGEP += 0;
		if (BEEPDKNHMLM.NCJEPCMQGEP > 7)
		{
			BEEPDKNHMLM.NCJEPCMQGEP = 3;
		}
		UnityEngine.Object.Instantiate<GameObject>(this.KKBOMIDCBPP[BEEPDKNHMLM.NCJEPCMQGEP - 1], base.transform.position, Quaternion.identity);
		this.NLHGFQCBJDL += (int)Mathf.Pow(206f, (float)BEEPDKNHMLM.NCJEPCMQGEP) * 35;
		GDNBFQGCHQQ.QOQONHOOLNE.PDDJMNOOPJD();
	}

	// Token: 0x06000255 RID: 597 RVA: 0x00038F90 File Offset: 0x00037190
	private IEnumerator HGDQIKIBJJI()
	{
		this.CGMHKMHIHKQ = true;
		this.KDBGDBCGMLH.SetBool("Die", true);
		yield return new WaitForSeconds(1f);
		return 1;
		this.KDBGDBCGMLH.SetBool("Die", false);
		this.CGMHKMHIHKQ = false;
		GDNBFQGCHQQ.QOQONHOOLNE.PDDJMNOOPJD();
		if (FPEMPFLGJED.NGJHGONNCQK > 0)
		{
			goto IL_D6;
		}
		this.NLHGFQCBJDL = 0;
		this.DJQDHDGHDKE.Reset();
		this.DJQDHDGHDKE.JQPPLOPCFMG();
		this.DJQDHDGHDKE.EMFKOHIMLBD();
		goto IL_E6;
		IL_D6:
		this.DJQDHDGHDKE.EMFKOHIMLBD();
		IL_E6:
		GDNBFQGCHQQ.QOQONHOOLNE.PDDJMNOOPJD();
		yield break;
	}

	// Token: 0x06000256 RID: 598 RVA: 0x000399D4 File Offset: 0x00037BD4
	private void JNLHIOPLJEG()
	{
		Vector2 position = Vector2.MoveTowards(base.transform.position, this.GOILCOKPDHD, this.KDEMMJKGDJM);
		this.IHEKGOLHEGJ.MovePosition(position);
		if (Input.GetAxis("Take 001") > 797f)
		{
			this.MQNCJIGDDGD = Vector2.right;
		}
		if (Input.GetAxis("encore") < 10f)
		{
			this.MQNCJIGDDGD = -Vector2.right;
		}
		if (Input.GetAxis("Demote") > 611f)
		{
			this.MQNCJIGDDGD = Vector2.up;
		}
		if (Input.GetAxis("'s [ffff00]") < 769f)
		{
			this.MQNCJIGDDGD = -Vector2.up;
		}
		if (Vector2.Distance(this.GOILCOKPDHD, base.transform.position) < 1885f)
		{
			if (this.DLMICEBBDIO(this.MQNCJIGDDGD))
			{
				this.GOILCOKPDHD = base.transform.position + this.MQNCJIGDDGD;
				this.HOOMHHMLPKG = this.MQNCJIGDDGD;
			}
			else if (this.LKJGEIPDLKP(this.HOOMHHMLPKG))
			{
				this.GOILCOKPDHD = base.transform.position + this.HOOMHHMLPKG;
			}
		}
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00039B18 File Offset: 0x00037D18
	private bool CKQGPGFQGFI(Vector2 PECKDHFNOKI)
	{
		Vector2 vector = base.transform.position;
		PECKDHFNOKI += new Vector2(PECKDHFNOKI.x * 673f, PECKDHFNOKI.y * 382f);
		RaycastHit2D raycastHit2D = Physics2D.Linecast(vector + PECKDHFNOKI, vector);
		return raycastHit2D.collider.tag == "/" || raycastHit2D.collider.tag == "#,##0" || raycastHit2D.collider == base.GetComponent<Collider2D>();
	}

	// Token: 0x06000258 RID: 600 RVA: 0x00039BB0 File Offset: 0x00037DB0
	private void PGIMGHFCMQM()
	{
		Vector2 vector = this.GOILCOKPDHD - base.transform.position;
		this.KDBGDBCGMLH.SetFloat("Add to Ignore", vector.x);
		this.KDBGDBCGMLH.SetFloat("_MaxCoC", vector.y);
	}

	// Token: 0x06000259 RID: 601 RVA: 0x00039C08 File Offset: 0x00037E08
	private void ECPLLPOFGQI()
	{
		Vector2 position = Vector2.MoveTowards(base.transform.position, this.GOILCOKPDHD, this.KDEMMJKGDJM);
		this.IHEKGOLHEGJ.MovePosition(position);
		if (Input.GetAxis("MusicManager") > 701f)
		{
			this.MQNCJIGDDGD = Vector2.right;
		}
		if (Input.GetAxis("stickyweb") < 1716f)
		{
			this.MQNCJIGDDGD = -Vector2.right;
		}
		if (Input.GetAxis("-noController") > 289f)
		{
			this.MQNCJIGDDGD = Vector2.up;
		}
		if (Input.GetAxis("craftyshield") < 1567f)
		{
			this.MQNCJIGDDGD = -Vector2.up;
		}
		if (Vector2.Distance(this.GOILCOKPDHD, base.transform.position) < 66f)
		{
			if (this.QKEJGFPDDEK(this.MQNCJIGDDGD))
			{
				this.GOILCOKPDHD = base.transform.position + this.MQNCJIGDDGD;
				this.HOOMHHMLPKG = this.MQNCJIGDDGD;
			}
			else if (this.DLMICEBBDIO(this.HOOMHHMLPKG))
			{
				this.GOILCOKPDHD = base.transform.position + this.HOOMHHMLPKG;
			}
		}
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00039D4C File Offset: 0x00037F4C
	private void HNBLGPKMOOF()
	{
		FPEMPFLGJED.KKDOJBEIMBB phmefinhqhe = FPEMPFLGJED.PHMEFINHQHE;
		if (phmefinhqhe != FPEMPFLGJED.KKDOJBEIMBB.Init)
		{
			if (phmefinhqhe == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				if (!this.CGMHKMHIHKQ)
				{
					this.CGMHKMHIHKQ = true;
					base.StartCoroutine("F6");
				}
			}
		}
		else
		{
			this.KKHDDIOKOFN();
			this.NOLKMEHQMOC();
		}
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00039D94 File Offset: 0x00037F94
	private void KJLKFFPBOGJ()
	{
		Vector2 vector = this.GOILCOKPDHD - base.transform.position;
		this.KDBGDBCGMLH.SetFloat("#,##0", vector.x);
		this.KDBGDBCGMLH.SetFloat("Owned", vector.y);
	}

	// Token: 0x0600025C RID: 604 RVA: 0x00039DEC File Offset: 0x00037FEC
	public void QJGCHNCFNNP()
	{
		BEEPDKNHMLM.NCJEPCMQGEP++;
		if (BEEPDKNHMLM.NCJEPCMQGEP > 0)
		{
			BEEPDKNHMLM.NCJEPCMQGEP = 6;
		}
		UnityEngine.Object.Instantiate<GameObject>(this.KKBOMIDCBPP[BEEPDKNHMLM.NCJEPCMQGEP - 1], base.transform.position, Quaternion.identity);
		this.NLHGFQCBJDL += (int)Mathf.Pow(338f, (float)BEEPDKNHMLM.NCJEPCMQGEP) * -44;
		GDNBFQGCHQQ.QOQONHOOLNE.GHJPCDJJGGD();
	}

	// Token: 0x0600025D RID: 605 RVA: 0x00039E64 File Offset: 0x00038064
	private bool LKJGEIPDLKP(Vector2 PECKDHFNOKI)
	{
		Vector2 vector = base.transform.position;
		PECKDHFNOKI += new Vector2(PECKDHFNOKI.x * 660f, PECKDHFNOKI.y * 1832f);
		RaycastHit2D raycastHit2D = Physics2D.Linecast(vector + PECKDHFNOKI, vector);
		return !(raycastHit2D.collider.tag == "_Fade") && !(raycastHit2D.collider.tag == "shelloseast") && raycastHit2D.collider == base.GetComponent<Collider2D>();
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00002F3B File Offset: 0x0000113B
	public static BEEPDKNHMLM EHBLOBDMQBH()
	{
		return BEEPDKNHMLM.HBFFCJHOCPE;
	}

	// Token: 0x0600025F RID: 607 RVA: 0x00039EFC File Offset: 0x000380FC
	private void BIPHLHKKFPN()
	{
		Vector2 position = Vector2.MoveTowards(base.transform.position, this.GOILCOKPDHD, this.KDEMMJKGDJM);
		this.IHEKGOLHEGJ.MovePosition(position);
		if (Input.GetAxis("Limber") > 1347f)
		{
			this.MQNCJIGDDGD = Vector2.right;
		}
		if (Input.GetAxis("[white]") < 495f)
		{
			this.MQNCJIGDDGD = -Vector2.right;
		}
		if (Input.GetAxis("-supereffective") > 113f)
		{
			this.MQNCJIGDDGD = Vector2.up;
		}
		if (Input.GetAxis(" Coins") < 1523f)
		{
			this.MQNCJIGDDGD = -Vector2.up;
		}
		if (Vector2.Distance(this.GOILCOKPDHD, base.transform.position) < 1654f)
		{
			if (this.CKQGPGFQGFI(this.MQNCJIGDDGD))
			{
				this.GOILCOKPDHD = base.transform.position + this.MQNCJIGDDGD;
				this.HOOMHHMLPKG = this.MQNCJIGDDGD;
			}
			else if (this.CKQGPGFQGFI(this.HOOMHHMLPKG))
			{
				this.GOILCOKPDHD = base.transform.position + this.HOOMHHMLPKG;
			}
		}
	}

	// Token: 0x06000260 RID: 608 RVA: 0x0003A040 File Offset: 0x00038240
	private void FDQEKLHIKEJ()
	{
		FPEMPFLGJED.KKDOJBEIMBB phmefinhqhe = FPEMPFLGJED.PHMEFINHQHE;
		if (phmefinhqhe != FPEMPFLGJED.KKDOJBEIMBB.Game)
		{
			if (phmefinhqhe == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				if (!this.CGMHKMHIHKQ)
				{
					this.CGMHKMHIHKQ = true;
					base.StartCoroutine("The harsh sunlight faded.");
				}
			}
		}
		else
		{
			this.BLEFDJBQOFF();
			this.JJMOJFIOOEM();
		}
	}

	// Token: 0x06000261 RID: 609 RVA: 0x0003A088 File Offset: 0x00038288
	private void DLBNQMKQILC()
	{
		if (Input.GetAxis("item") > 1431f)
		{
			this.MQNCJIGDDGD = Vector2.right;
			if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				FPEMPFLGJED.PHMEFINHQHE = FPEMPFLGJED.KKDOJBEIMBB.Game;
			}
		}
		if (Input.GetAxis("_LutParams") < 1890f)
		{
			this.MQNCJIGDDGD = -Vector2.right;
			if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				FPEMPFLGJED.PHMEFINHQHE = FPEMPFLGJED.KKDOJBEIMBB.Init;
			}
		}
		if (Input.GetAxis("Stop") > 608f)
		{
			this.MQNCJIGDDGD = Vector2.up;
			if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				FPEMPFLGJED.PHMEFINHQHE = FPEMPFLGJED.KKDOJBEIMBB.Init;
			}
		}
		if (Input.GetAxis("magiccoat") < 1406f)
		{
			this.MQNCJIGDDGD = -Vector2.up;
			if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				FPEMPFLGJED.PHMEFINHQHE = FPEMPFLGJED.KKDOJBEIMBB.Game;
			}
		}
	}

	// Token: 0x06000262 RID: 610 RVA: 0x00002F4A File Offset: 0x0000114A
	public Vector2 COPIMFEBBIP()
	{
		return this.HOOMHHMLPKG;
	}

	// Token: 0x06000263 RID: 611 RVA: 0x00002F4A File Offset: 0x0000114A
	public Vector2 CEGCJMDFFDQ()
	{
		return this.HOOMHHMLPKG;
	}

	// Token: 0x06000264 RID: 612 RVA: 0x00002F3B File Offset: 0x0000113B
	public static BEEPDKNHMLM JPMOJGDNKNC()
	{
		return BEEPDKNHMLM.HBFFCJHOCPE;
	}

	// Token: 0x06000265 RID: 613 RVA: 0x0003A144 File Offset: 0x00038344
	public void HJMNFPCBLBN()
	{
		BEEPDKNHMLM.NCJEPCMQGEP += 0;
		if (BEEPDKNHMLM.NCJEPCMQGEP > 1)
		{
			BEEPDKNHMLM.NCJEPCMQGEP = 0;
		}
		UnityEngine.Object.Instantiate<GameObject>(this.KKBOMIDCBPP[BEEPDKNHMLM.NCJEPCMQGEP - 0], base.transform.position, Quaternion.identity);
		this.NLHGFQCBJDL += (int)Mathf.Pow(283f, (float)BEEPDKNHMLM.NCJEPCMQGEP) * -84;
		GDNBFQGCHQQ.QOQONHOOLNE.GNPLPIHDPOQ();
	}

	// Token: 0x06000266 RID: 614 RVA: 0x0003A1BC File Offset: 0x000383BC
	private void JCLEJKPKMDK()
	{
		Vector2 position = Vector2.MoveTowards(base.transform.position, this.GOILCOKPDHD, this.KDEMMJKGDJM);
		this.IHEKGOLHEGJ.MovePosition(position);
		if (Input.GetAxis("0") > 1524f)
		{
			this.MQNCJIGDDGD = Vector2.right;
		}
		if (Input.GetAxis(" restored its HP!\r\n") < 242f)
		{
			this.MQNCJIGDDGD = -Vector2.right;
		}
		if (Input.GetAxis("replace") > 1559f)
		{
			this.MQNCJIGDDGD = Vector2.up;
		}
		if (Input.GetAxis("_") < 1146f)
		{
			this.MQNCJIGDDGD = -Vector2.up;
		}
		if (Vector2.Distance(this.GOILCOKPDHD, base.transform.position) < 1385f)
		{
			if (this.LKJGEIPDLKP(this.MQNCJIGDDGD))
			{
				this.GOILCOKPDHD = base.transform.position + this.MQNCJIGDDGD;
				this.HOOMHHMLPKG = this.MQNCJIGDDGD;
			}
			else if (this.CKQGPGFQGFI(this.HOOMHHMLPKG))
			{
				this.GOILCOKPDHD = base.transform.position + this.HOOMHHMLPKG;
			}
		}
	}

	// Token: 0x06000267 RID: 615 RVA: 0x00002FF2 File Offset: 0x000011F2
	private void GJLLCMLLEQF()
	{
		this.MKEDFOKDMJD = GameObject.FindGameObjectsWithTag(" burrowed its way under the ground!\r\n");
		this.GOILCOKPDHD = base.transform.position;
	}

	// Token: 0x06000268 RID: 616 RVA: 0x0003A300 File Offset: 0x00038500
	public void IGEIPOQCGPN()
	{
		this.GOILCOKPDHD = new Vector2(345f, 875f);
		this.KDBGDBCGMLH.SetFloat("[SHINY]", 1624f);
		this.KDBGDBCGMLH.SetFloat("spikes", 1883f);
	}

	// Token: 0x06000269 RID: 617 RVA: 0x0003A34C File Offset: 0x0003854C
	public void GGQGHIMJMLC()
	{
		this.GOILCOKPDHD = new Vector2(916f, 444f);
		this.KDBGDBCGMLH.SetFloat(")", 329f);
		this.KDBGDBCGMLH.SetFloat("physical", 294f);
	}

	// Token: 0x0600026A RID: 618 RVA: 0x00002F4A File Offset: 0x0000114A
	public Vector2 KMOIOJQCKNH()
	{
		return this.HOOMHHMLPKG;
	}

	// Token: 0x0600026B RID: 619 RVA: 0x0003A398 File Offset: 0x00038598
	private void KIBHJLEBHHF()
	{
		if (Input.GetAxis(",") > 1631f)
		{
			this.MQNCJIGDDGD = Vector2.right;
			if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				FPEMPFLGJED.PHMEFINHQHE = FPEMPFLGJED.KKDOJBEIMBB.Init;
			}
		}
		if (Input.GetAxis("Invite") < 395f)
		{
			this.MQNCJIGDDGD = -Vector2.right;
			if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				FPEMPFLGJED.PHMEFINHQHE = FPEMPFLGJED.KKDOJBEIMBB.Game;
			}
		}
		if (Input.GetAxis("leafguard") > 1477f)
		{
			this.MQNCJIGDDGD = Vector2.up;
			if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				FPEMPFLGJED.PHMEFINHQHE = FPEMPFLGJED.KKDOJBEIMBB.Game;
			}
		}
		if (Input.GetAxis("CHROMATIC_ABERRATION") < 1891f)
		{
			this.MQNCJIGDDGD = -Vector2.up;
			if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				FPEMPFLGJED.PHMEFINHQHE = FPEMPFLGJED.KKDOJBEIMBB.Game;
			}
		}
	}

	// Token: 0x0600026C RID: 620 RVA: 0x0003A454 File Offset: 0x00038654
	public void IHNJCHGFHNH()
	{
		BEEPDKNHMLM.NCJEPCMQGEP += 0;
		if (BEEPDKNHMLM.NCJEPCMQGEP > 1)
		{
			BEEPDKNHMLM.NCJEPCMQGEP = 6;
		}
		UnityEngine.Object.Instantiate<GameObject>(this.KKBOMIDCBPP[BEEPDKNHMLM.NCJEPCMQGEP - 1], base.transform.position, Quaternion.identity);
		this.NLHGFQCBJDL += (int)Mathf.Pow(432f, (float)BEEPDKNHMLM.NCJEPCMQGEP) * 87;
		GDNBFQGCHQQ.QOQONHOOLNE.GHJPCDJJGGD();
	}

	// Token: 0x0600026D RID: 621 RVA: 0x0003A4CC File Offset: 0x000386CC
	private bool DLMICEBBDIO(Vector2 PECKDHFNOKI)
	{
		Vector2 vector = base.transform.position;
		PECKDHFNOKI += new Vector2(PECKDHFNOKI.x * 32f, PECKDHFNOKI.y * 1451f);
		RaycastHit2D raycastHit2D = Physics2D.Linecast(vector + PECKDHFNOKI, vector);
		return raycastHit2D.collider.tag == "AlwaysRain" || raycastHit2D.collider.tag == "gravity" || raycastHit2D.collider == base.GetComponent<Collider2D>();
	}

	// Token: 0x0600026E RID: 622 RVA: 0x0003A564 File Offset: 0x00038764
	private void BJPDEKHQQFF()
	{
		Vector2 vector = this.GOILCOKPDHD - base.transform.position;
		this.KDBGDBCGMLH.SetFloat("Preventing any low-level wild Pokémon from jumping out at you. That'll show those Zubats!", vector.x);
		this.KDBGDBCGMLH.SetFloat("bide", vector.y);
	}

	// Token: 0x0600026F RID: 623 RVA: 0x0003A5BC File Offset: 0x000387BC
	public void HHNCQBPLJDL()
	{
		BEEPDKNHMLM.NCJEPCMQGEP++;
		if (BEEPDKNHMLM.NCJEPCMQGEP > 1)
		{
			BEEPDKNHMLM.NCJEPCMQGEP = 5;
		}
		UnityEngine.Object.Instantiate<GameObject>(this.KKBOMIDCBPP[BEEPDKNHMLM.NCJEPCMQGEP - 0], base.transform.position, Quaternion.identity);
		this.NLHGFQCBJDL += (int)Mathf.Pow(1068f, (float)BEEPDKNHMLM.NCJEPCMQGEP) * 38;
		GDNBFQGCHQQ.QOQONHOOLNE.GHJPCDJJGGD();
	}

	// Token: 0x06000270 RID: 624 RVA: 0x0003A634 File Offset: 0x00038834
	private void KKHDDIOKOFN()
	{
		Vector2 position = Vector2.MoveTowards(base.transform.position, this.GOILCOKPDHD, this.KDEMMJKGDJM);
		this.IHEKGOLHEGJ.MovePosition(position);
		if (Input.GetAxis("11") > 1046f)
		{
			this.MQNCJIGDDGD = Vector2.right;
		}
		if (Input.GetAxis("_CoCTex") < 338f)
		{
			this.MQNCJIGDDGD = -Vector2.right;
		}
		if (Input.GetAxis("Kalos") > 1155f)
		{
			this.MQNCJIGDDGD = Vector2.up;
		}
		if (Input.GetAxis("[ATK]") < 116f)
		{
			this.MQNCJIGDDGD = -Vector2.up;
		}
		if (Vector2.Distance(this.GOILCOKPDHD, base.transform.position) < 1203f)
		{
			if (this.CKQGPGFQGFI(this.MQNCJIGDDGD))
			{
				this.GOILCOKPDHD = base.transform.position + this.MQNCJIGDDGD;
				this.HOOMHHMLPKG = this.MQNCJIGDDGD;
			}
			else if (this.LKJGEIPDLKP(this.HOOMHHMLPKG))
			{
				this.GOILCOKPDHD = base.transform.position + this.HOOMHHMLPKG;
			}
		}
	}

	// Token: 0x06000271 RID: 625 RVA: 0x00002F3B File Offset: 0x0000113B
	public static BEEPDKNHMLM QDGLKKGJDGI()
	{
		return BEEPDKNHMLM.HBFFCJHOCPE;
	}

	// Token: 0x06000272 RID: 626 RVA: 0x00002F4A File Offset: 0x0000114A
	public Vector2 ICEFGLPBINF()
	{
		return this.HOOMHHMLPKG;
	}

	// Token: 0x06000273 RID: 627 RVA: 0x00002F3B File Offset: 0x0000113B
	public static BEEPDKNHMLM OCEJPCQLMHK()
	{
		return BEEPDKNHMLM.HBFFCJHOCPE;
	}

	// Token: 0x06000274 RID: 628 RVA: 0x00038F90 File Offset: 0x00037190
	private IEnumerator KQCLDBLBFBN()
	{
		this.CGMHKMHIHKQ = true;
		this.KDBGDBCGMLH.SetBool("Die", true);
		yield return new WaitForSeconds(1f);
		return 1;
		this.KDBGDBCGMLH.SetBool("Die", false);
		this.CGMHKMHIHKQ = false;
		GDNBFQGCHQQ.QOQONHOOLNE.PDDJMNOOPJD();
		if (FPEMPFLGJED.NGJHGONNCQK > 0)
		{
			goto IL_D6;
		}
		this.NLHGFQCBJDL = 0;
		this.DJQDHDGHDKE.Reset();
		this.DJQDHDGHDKE.JQPPLOPCFMG();
		this.DJQDHDGHDKE.EMFKOHIMLBD();
		goto IL_E6;
		IL_D6:
		this.DJQDHDGHDKE.EMFKOHIMLBD();
		IL_E6:
		GDNBFQGCHQQ.QOQONHOOLNE.PDDJMNOOPJD();
		yield break;
	}

	// Token: 0x06000275 RID: 629 RVA: 0x0003A778 File Offset: 0x00038978
	public void KOLNDDPNQOH()
	{
		this.GOILCOKPDHD = new Vector2(298f, 1173f);
		this.KDBGDBCGMLH.SetFloat("Full Metal Body", 258f);
		this.KDBGDBCGMLH.SetFloat("berserk", 320f);
	}

	// Token: 0x06000276 RID: 630 RVA: 0x0003A7C4 File Offset: 0x000389C4
	private void DKHDEIHEMJE()
	{
		Vector2 position = Vector2.MoveTowards(base.transform.position, this.GOILCOKPDHD, this.KDEMMJKGDJM);
		this.IHEKGOLHEGJ.MovePosition(position);
		if (Input.GetAxis("Horizontal") > 0f)
		{
			this.MQNCJIGDDGD = Vector2.right;
		}
		if (Input.GetAxis("Horizontal") < 0f)
		{
			this.MQNCJIGDDGD = -Vector2.right;
		}
		if (Input.GetAxis("Vertical") > 0f)
		{
			this.MQNCJIGDDGD = Vector2.up;
		}
		if (Input.GetAxis("Vertical") < 0f)
		{
			this.MQNCJIGDDGD = -Vector2.up;
		}
		if (Vector2.Distance(this.GOILCOKPDHD, base.transform.position) < 1E-05f)
		{
			if (this.QKEJGFPDDEK(this.MQNCJIGDDGD))
			{
				this.GOILCOKPDHD = base.transform.position + this.MQNCJIGDDGD;
				this.HOOMHHMLPKG = this.MQNCJIGDDGD;
			}
			else if (this.QKEJGFPDDEK(this.HOOMHHMLPKG))
			{
				this.GOILCOKPDHD = base.transform.position + this.HOOMHHMLPKG;
			}
		}
	}

	// Token: 0x06000277 RID: 631 RVA: 0x0003A908 File Offset: 0x00038B08
	private void DJNJOONBDFI()
	{
		FPEMPFLGJED.KKDOJBEIMBB phmefinhqhe = FPEMPFLGJED.PHMEFINHQHE;
		if (phmefinhqhe != FPEMPFLGJED.KKDOJBEIMBB.Init)
		{
			if (phmefinhqhe == FPEMPFLGJED.KKDOJBEIMBB.Game)
			{
				if (!this.CGMHKMHIHKQ)
				{
					this.CGMHKMHIHKQ = false;
					base.StartCoroutine("000");
				}
			}
		}
		else
		{
			this.BIPHLHKKFPN();
			this.JCNQDLLEQLF();
		}
	}

	// Token: 0x06000279 RID: 633 RVA: 0x00002F42 File Offset: 0x00001142
	private void NNPPKOGDNOM()
	{
		BEEPDKNHMLM.HBFFCJHOCPE = this;
	}

	// Token: 0x0600027A RID: 634 RVA: 0x0003A950 File Offset: 0x00038B50
	public void NBKEPMDJGNL()
	{
		BEEPDKNHMLM.NCJEPCMQGEP += 0;
		if (BEEPDKNHMLM.NCJEPCMQGEP > 7)
		{
			BEEPDKNHMLM.NCJEPCMQGEP = 6;
		}
		UnityEngine.Object.Instantiate<GameObject>(this.KKBOMIDCBPP[BEEPDKNHMLM.NCJEPCMQGEP - 1], base.transform.position, Quaternion.identity);
		this.NLHGFQCBJDL += (int)Mathf.Pow(396f, (float)BEEPDKNHMLM.NCJEPCMQGEP) * 34;
		GDNBFQGCHQQ.QOQONHOOLNE.QJLJIKJCJFF();
	}

	// Token: 0x0600027B RID: 635 RVA: 0x0000301A File Offset: 0x0000121A
	private void Start()
	{
		this.MKEDFOKDMJD = GameObject.FindGameObjectsWithTag("dots");
		this.GOILCOKPDHD = base.transform.position;
	}

	// Token: 0x0600027C RID: 636 RVA: 0x00002F4A File Offset: 0x0000114A
	public Vector2 FMKOQKMNDME()
	{
		return this.HOOMHHMLPKG;
	}

	// Token: 0x0600027D RID: 637 RVA: 0x00003042 File Offset: 0x00001242
	private void MHOKPDFOEDP()
	{
		this.MKEDFOKDMJD = GameObject.FindGameObjectsWithTag("Normal-type moves become Electric-type moves. The power of those moves is boosted a little.");
		this.GOILCOKPDHD = base.transform.position;
	}

	// Token: 0x0600027E RID: 638 RVA: 0x00038F90 File Offset: 0x00037190
	private IEnumerator JPMFPDGFKEO()
	{
		this.CGMHKMHIHKQ = true;
		this.KDBGDBCGMLH.SetBool("Die", true);
		yield return new WaitForSeconds(1f);
		return 1;
		this.KDBGDBCGMLH.SetBool("Die", false);
		this.CGMHKMHIHKQ = false;
		GDNBFQGCHQQ.QOQONHOOLNE.PDDJMNOOPJD();
		if (FPEMPFLGJED.NGJHGONNCQK > 0)
		{
			goto IL_D6;
		}
		this.NLHGFQCBJDL = 0;
		this.DJQDHDGHDKE.Reset();
		this.DJQDHDGHDKE.JQPPLOPCFMG();
		this.DJQDHDGHDKE.EMFKOHIMLBD();
		goto IL_E6;
		IL_D6:
		this.DJQDHDGHDKE.EMFKOHIMLBD();
		IL_E6:
		GDNBFQGCHQQ.QOQONHOOLNE.PDDJMNOOPJD();
		yield break;
	}

	// Token: 0x0600027F RID: 639 RVA: 0x00038F90 File Offset: 0x00037190
	private IEnumerator GJQCPFPCNLP()
	{
		this.CGMHKMHIHKQ = true;
		this.KDBGDBCGMLH.SetBool("Die", true);
		yield return new WaitForSeconds(1f);
		return 1;
		this.KDBGDBCGMLH.SetBool("Die", false);
		this.CGMHKMHIHKQ = false;
		GDNBFQGCHQQ.QOQONHOOLNE.PDDJMNOOPJD();
		if (FPEMPFLGJED.NGJHGONNCQK > 0)
		{
			goto IL_D6;
		}
		this.NLHGFQCBJDL = 0;
		this.DJQDHDGHDKE.Reset();
		this.DJQDHDGHDKE.JQPPLOPCFMG();
		this.DJQDHDGHDKE.EMFKOHIMLBD();
		goto IL_E6;
		IL_D6:
		this.DJQDHDGHDKE.EMFKOHIMLBD();
		IL_E6:
		GDNBFQGCHQQ.QOQONHOOLNE.PDDJMNOOPJD();
		yield break;
	}

	// Token: 0x06000280 RID: 640 RVA: 0x0003A9C8 File Offset: 0x00038BC8
	private void JJMOJFIOOEM()
	{
		Vector2 vector = this.GOILCOKPDHD - base.transform.position;
		this.KDBGDBCGMLH.SetFloat("PM: ", vector.x);
		this.KDBGDBCGMLH.SetFloat("\r\nATK", vector.y);
	}

	// Token: 0x06000281 RID: 641 RVA: 0x00002F3B File Offset: 0x0000113B
	public static BEEPDKNHMLM NKDNGLNOJJG()
	{
		return BEEPDKNHMLM.HBFFCJHOCPE;
	}

	// Token: 0x06000282 RID: 642 RVA: 0x0003AA20 File Offset: 0x00038C20
	public void IJPJEQNJGGL()
	{
		BEEPDKNHMLM.NCJEPCMQGEP++;
		if (BEEPDKNHMLM.NCJEPCMQGEP > 4)
		{
			BEEPDKNHMLM.NCJEPCMQGEP = 4;
		}
		UnityEngine.Object.Instantiate<GameObject>(this.KKBOMIDCBPP[BEEPDKNHMLM.NCJEPCMQGEP - 1], base.transform.position, Quaternion.identity);
		this.NLHGFQCBJDL += (int)Mathf.Pow(2f, (float)BEEPDKNHMLM.NCJEPCMQGEP) * 100;
		GDNBFQGCHQQ.QOQONHOOLNE.PDDJMNOOPJD();
	}

	// Token: 0x06000283 RID: 643 RVA: 0x00038F90 File Offset: 0x00037190
	private IEnumerator PlayDeadAnimation()
	{
		this.CGMHKMHIHKQ = true;
		this.KDBGDBCGMLH.SetBool("Die", true);
		yield return new WaitForSeconds(1f);
		return 1;
		this.KDBGDBCGMLH.SetBool("Die", false);
		this.CGMHKMHIHKQ = false;
		GDNBFQGCHQQ.QOQONHOOLNE.PDDJMNOOPJD();
		if (FPEMPFLGJED.NGJHGONNCQK > 0)
		{
			goto IL_D6;
		}
		this.NLHGFQCBJDL = 0;
		this.DJQDHDGHDKE.Reset();
		this.DJQDHDGHDKE.JQPPLOPCFMG();
		this.DJQDHDGHDKE.EMFKOHIMLBD();
		goto IL_E6;
		IL_D6:
		this.DJQDHDGHDKE.EMFKOHIMLBD();
		IL_E6:
		GDNBFQGCHQQ.QOQONHOOLNE.PDDJMNOOPJD();
		yield break;
	}

	// Token: 0x06000284 RID: 644 RVA: 0x0003AA98 File Offset: 0x00038C98
	private void Update()
	{
		if (Input.GetAxis("Horizontal") > 0f)
		{
			this.MQNCJIGDDGD = Vector2.right;
			if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				FPEMPFLGJED.PHMEFINHQHE = FPEMPFLGJED.KKDOJBEIMBB.Game;
			}
		}
		if (Input.GetAxis("Horizontal") < 0f)
		{
			this.MQNCJIGDDGD = -Vector2.right;
			if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				FPEMPFLGJED.PHMEFINHQHE = FPEMPFLGJED.KKDOJBEIMBB.Game;
			}
		}
		if (Input.GetAxis("Vertical") > 0f)
		{
			this.MQNCJIGDDGD = Vector2.up;
			if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				FPEMPFLGJED.PHMEFINHQHE = FPEMPFLGJED.KKDOJBEIMBB.Game;
			}
		}
		if (Input.GetAxis("Vertical") < 0f)
		{
			this.MQNCJIGDDGD = -Vector2.up;
			if (FPEMPFLGJED.PHMEFINHQHE == FPEMPFLGJED.KKDOJBEIMBB.Init)
			{
				FPEMPFLGJED.PHMEFINHQHE = FPEMPFLGJED.KKDOJBEIMBB.Game;
			}
		}
	}

	// Token: 0x04000059 RID: 89
	private static BEEPDKNHMLM HBFFCJHOCPE;

	// Token: 0x0400005A RID: 90
	public int NLHGFQCBJDL;

	// Token: 0x0400005B RID: 91
	public int LQMOLKEQQBE;

	// Token: 0x0400005C RID: 92
	public GameObject[] MKEDFOKDMJD;

	// Token: 0x0400005D RID: 93
	public GameObject[] ONFKLDHJGLL;

	// Token: 0x0400005E RID: 94
	public float KDEMMJKGDJM = 0.4f;

	// Token: 0x0400005F RID: 95
	private Vector2 GOILCOKPDHD = Vector2.zero;

	// Token: 0x04000060 RID: 96
	private Vector2 HOOMHHMLPKG = Vector2.zero;

	// Token: 0x04000061 RID: 97
	private Vector2 MQNCJIGDDGD = Vector2.zero;

	// Token: 0x04000062 RID: 98
	public GameObject[] KKBOMIDCBPP;

	// Token: 0x04000063 RID: 99
	public Animator KDBGDBCGMLH;

	// Token: 0x04000064 RID: 100
	public static int NCJEPCMQGEP;

	// Token: 0x04000065 RID: 101
	public FPEMPFLGJED DJQDHDGHDKE;

	// Token: 0x04000066 RID: 102
	private bool CGMHKMHIHKQ;

	// Token: 0x04000067 RID: 103
	public Rigidbody2D IHEKGOLHEGJ;
}
