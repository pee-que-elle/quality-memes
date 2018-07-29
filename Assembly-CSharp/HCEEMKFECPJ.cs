using System;
using UnityEngine;

// Token: 0x02000022 RID: 34
[AddComponentMenu("NGUI/Examples/UI Cursor")]
[RequireComponent(typeof(PLQFPBQEPJD))]
public class HCEEMKFECPJ : MonoBehaviour
{
	// Token: 0x06000540 RID: 1344 RVA: 0x00004215 File Offset: 0x00002415
	public static void MMQJCBNOLJJ()
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML != null)
		{
			HCEEMKFECPJ.PJMIKDIEGMB(HCEEMKFECPJ.HBFFCJHOCPE.JHIOGFKJMIN, HCEEMKFECPJ.HBFFCJHOCPE.PJQNBIONQQB);
		}
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x0004CE60 File Offset: 0x0004B060
	public static void HNIJKCKHOFK(BPLKJMJMHFI QKGJDCFCPMO, string QDDJBICKQIG)
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML)
		{
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.OKDFHDLPQEM(QKGJDCFCPMO);
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.JOHBNEHCEJH(QDDJBICKQIG);
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.IQFQEOFBQKM();
			HCEEMKFECPJ.HBFFCJHOCPE.FKFEDINPBFF();
		}
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x0000424F File Offset: 0x0000244F
	public static void QNCMFDFKNCQ()
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML != null)
		{
			HCEEMKFECPJ.BLPNGMMJHNG(HCEEMKFECPJ.HBFFCJHOCPE.JHIOGFKJMIN, HCEEMKFECPJ.HBFFCJHOCPE.PJQNBIONQQB);
		}
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x00004289 File Offset: 0x00002489
	private void OnDestroy()
	{
		HCEEMKFECPJ.HBFFCJHOCPE = null;
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x0004CEC4 File Offset: 0x0004B0C4
	private void EMFBQIQLGMD()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (this.CODFIINNNPG != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(mousePosition);
			if (this.CODFIINNNPG.orthographic)
			{
				Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				this.BLLEFKOLKLP.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 120f;
			mousePosition.y -= (float)Screen.height * 879f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			this.BLLEFKOLKLP.localPosition = mousePosition;
		}
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x0004CFEC File Offset: 0x0004B1EC
	private void BCDLNCLKKBM()
	{
		this.BLLEFKOLKLP = base.transform;
		this.LNMJLFLDCML = base.GetComponentInChildren<PLQFPBQEPJD>();
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		if (this.LNMJLFLDCML != null)
		{
			this.JHIOGFKJMIN = this.LNMJLFLDCML.QKGJDCFCPMO;
			this.PJQNBIONQQB = this.LNMJLFLDCML.GQKEMOHHIMK();
			if (this.LNMJLFLDCML.LGCLGHDGNPM < -15)
			{
				this.LNMJLFLDCML.LGCLGHDGNPM = 92;
			}
		}
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x00004289 File Offset: 0x00002489
	private void DFDIKBGJIPK()
	{
		HCEEMKFECPJ.HBFFCJHOCPE = null;
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x00004289 File Offset: 0x00002489
	private void HGFCQIKLPDO()
	{
		HCEEMKFECPJ.HBFFCJHOCPE = null;
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x0004D084 File Offset: 0x0004B284
	public static void PJMIKDIEGMB(BPLKJMJMHFI QKGJDCFCPMO, string QDDJBICKQIG)
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML)
		{
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.QKGJDCFCPMO = QKGJDCFCPMO;
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.KCLBMPFIPNQ = QDDJBICKQIG;
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.IQFQEOFBQKM();
			HCEEMKFECPJ.HBFFCJHOCPE.Update();
		}
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00004291 File Offset: 0x00002491
	public static void PEPMLINQGOC()
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML != null)
		{
			HCEEMKFECPJ.LGHCHMIDGFO(HCEEMKFECPJ.HBFFCJHOCPE.JHIOGFKJMIN, HCEEMKFECPJ.HBFFCJHOCPE.PJQNBIONQQB);
		}
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x0004D0E8 File Offset: 0x0004B2E8
	private void OLLNOFNEEIL()
	{
		this.BLLEFKOLKLP = base.transform;
		this.LNMJLFLDCML = base.GetComponentInChildren<PLQFPBQEPJD>();
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		if (this.LNMJLFLDCML != null)
		{
			this.JHIOGFKJMIN = this.LNMJLFLDCML.QKGJDCFCPMO;
			this.PJQNBIONQQB = this.LNMJLFLDCML.MHINCMBDLCB();
			if (this.LNMJLFLDCML.LGCLGHDGNPM < 118)
			{
				this.LNMJLFLDCML.LGCLGHDGNPM = -103;
			}
		}
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x0004D180 File Offset: 0x0004B380
	private void JDLQNCEDMPI()
	{
		this.BLLEFKOLKLP = base.transform;
		this.LNMJLFLDCML = base.GetComponentInChildren<PLQFPBQEPJD>();
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		if (this.LNMJLFLDCML != null)
		{
			this.JHIOGFKJMIN = this.LNMJLFLDCML.QKGJDCFCPMO;
			this.PJQNBIONQQB = this.LNMJLFLDCML.KCLBMPFIPNQ;
			if (this.LNMJLFLDCML.LGCLGHDGNPM < -125)
			{
				this.LNMJLFLDCML.LGCLGHDGNPM = 24;
			}
		}
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x00004215 File Offset: 0x00002415
	public static void CPLBKPNNHJG()
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML != null)
		{
			HCEEMKFECPJ.PJMIKDIEGMB(HCEEMKFECPJ.HBFFCJHOCPE.JHIOGFKJMIN, HCEEMKFECPJ.HBFFCJHOCPE.PJQNBIONQQB);
		}
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x00004289 File Offset: 0x00002489
	private void GIBCBGBKIGQ()
	{
		HCEEMKFECPJ.HBFFCJHOCPE = null;
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x0004D218 File Offset: 0x0004B418
	public static void NPECJKGLCHJ(BPLKJMJMHFI QKGJDCFCPMO, string QDDJBICKQIG)
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML)
		{
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.OKDFHDLPQEM(QKGJDCFCPMO);
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.JOHBNEHCEJH(QDDJBICKQIG);
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.IQFQEOFBQKM();
			HCEEMKFECPJ.HBFFCJHOCPE.EMFBQIQLGMD();
		}
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x0004D27C File Offset: 0x0004B47C
	private void LMELGHDGJMQ()
	{
		this.BLLEFKOLKLP = base.transform;
		this.LNMJLFLDCML = base.GetComponentInChildren<PLQFPBQEPJD>();
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		if (this.LNMJLFLDCML != null)
		{
			this.JHIOGFKJMIN = this.LNMJLFLDCML.QKGJDCFCPMO;
			this.PJQNBIONQQB = this.LNMJLFLDCML.HQDQLOQPCOD();
			if (this.LNMJLFLDCML.LGCLGHDGNPM < 88)
			{
				this.LNMJLFLDCML.LGCLGHDGNPM = -41;
			}
		}
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x0004D314 File Offset: 0x0004B514
	private void Start()
	{
		this.BLLEFKOLKLP = base.transform;
		this.LNMJLFLDCML = base.GetComponentInChildren<PLQFPBQEPJD>();
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		if (this.LNMJLFLDCML != null)
		{
			this.JHIOGFKJMIN = this.LNMJLFLDCML.QKGJDCFCPMO;
			this.PJQNBIONQQB = this.LNMJLFLDCML.KCLBMPFIPNQ;
			if (this.LNMJLFLDCML.LGCLGHDGNPM < 100)
			{
				this.LNMJLFLDCML.LGCLGHDGNPM = 100;
			}
		}
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x0004D3AC File Offset: 0x0004B5AC
	private void QDIKKLMCIJK()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (this.CODFIINNNPG != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(mousePosition);
			if (this.CODFIINNNPG.orthographic)
			{
				Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				this.BLLEFKOLKLP.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 1386f;
			mousePosition.y -= (float)Screen.height * 1554f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			this.BLLEFKOLKLP.localPosition = mousePosition;
		}
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x0004D4D4 File Offset: 0x0004B6D4
	public static void NDNFHGENFGQ(BPLKJMJMHFI QKGJDCFCPMO, string QDDJBICKQIG)
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML)
		{
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.QKGJDCFCPMO = QKGJDCFCPMO;
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.JLENFJGDNFN(QDDJBICKQIG);
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.IQFQEOFBQKM();
			HCEEMKFECPJ.HBFFCJHOCPE.PIQDBCGQDCH();
		}
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x0004D538 File Offset: 0x0004B738
	private void LIFJCBMQELJ()
	{
		this.BLLEFKOLKLP = base.transform;
		this.LNMJLFLDCML = base.GetComponentInChildren<PLQFPBQEPJD>();
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		if (this.LNMJLFLDCML != null)
		{
			this.JHIOGFKJMIN = this.LNMJLFLDCML.QKGJDCFCPMO;
			this.PJQNBIONQQB = this.LNMJLFLDCML.MHINCMBDLCB();
			if (this.LNMJLFLDCML.LGCLGHDGNPM < -66)
			{
				this.LNMJLFLDCML.LGCLGHDGNPM = -32;
			}
		}
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x0004D5D0 File Offset: 0x0004B7D0
	public static void LGHCHMIDGFO(BPLKJMJMHFI QKGJDCFCPMO, string QDDJBICKQIG)
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML)
		{
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.QKGJDCFCPMO = QKGJDCFCPMO;
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.LGJOOQIBQDC(QDDJBICKQIG);
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.IQFQEOFBQKM();
			HCEEMKFECPJ.HBFFCJHOCPE.NLNIQPOMOGM();
		}
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x0004D634 File Offset: 0x0004B834
	public static void PFPEMBMIFNI(BPLKJMJMHFI QKGJDCFCPMO, string QDDJBICKQIG)
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML)
		{
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.QKGJDCFCPMO = QKGJDCFCPMO;
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.KCLBMPFIPNQ = QDDJBICKQIG;
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.IQFQEOFBQKM();
			HCEEMKFECPJ.HBFFCJHOCPE.FKFEDINPBFF();
		}
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x00004289 File Offset: 0x00002489
	private void LCGDDQPOGEG()
	{
		HCEEMKFECPJ.HBFFCJHOCPE = null;
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x0004D4D4 File Offset: 0x0004B6D4
	public static void HIJGPINFOGN(BPLKJMJMHFI QKGJDCFCPMO, string QDDJBICKQIG)
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML)
		{
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.QKGJDCFCPMO = QKGJDCFCPMO;
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.JLENFJGDNFN(QDDJBICKQIG);
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.IQFQEOFBQKM();
			HCEEMKFECPJ.HBFFCJHOCPE.PIQDBCGQDCH();
		}
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x000042CB File Offset: 0x000024CB
	public static void NJOGQEPKOBB()
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML != null)
		{
			HCEEMKFECPJ.HNIJKCKHOFK(HCEEMKFECPJ.HBFFCJHOCPE.JHIOGFKJMIN, HCEEMKFECPJ.HBFFCJHOCPE.PJQNBIONQQB);
		}
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x00004291 File Offset: 0x00002491
	public static void HMDOQOIIJIC()
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML != null)
		{
			HCEEMKFECPJ.LGHCHMIDGFO(HCEEMKFECPJ.HBFFCJHOCPE.JHIOGFKJMIN, HCEEMKFECPJ.HBFFCJHOCPE.PJQNBIONQQB);
		}
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x00004289 File Offset: 0x00002489
	private void BHJIKJLLIQQ()
	{
		HCEEMKFECPJ.HBFFCJHOCPE = null;
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x00004305 File Offset: 0x00002505
	private void ENOBPJMDNEG()
	{
		HCEEMKFECPJ.HBFFCJHOCPE = this;
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x0000430D File Offset: 0x0000250D
	public static void NOHJCKMOQJI()
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML != null)
		{
			HCEEMKFECPJ.NKMQJHBCCJI(HCEEMKFECPJ.HBFFCJHOCPE.JHIOGFKJMIN, HCEEMKFECPJ.HBFFCJHOCPE.PJQNBIONQQB);
		}
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x00004305 File Offset: 0x00002505
	private void Awake()
	{
		HCEEMKFECPJ.HBFFCJHOCPE = this;
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x00004291 File Offset: 0x00002491
	public static void HFCJILQBLKH()
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML != null)
		{
			HCEEMKFECPJ.LGHCHMIDGFO(HCEEMKFECPJ.HBFFCJHOCPE.JHIOGFKJMIN, HCEEMKFECPJ.HBFFCJHOCPE.PJQNBIONQQB);
		}
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x0004D698 File Offset: 0x0004B898
	private void MOLCLOMMJNQ()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (this.CODFIINNNPG != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(mousePosition);
			if (this.CODFIINNNPG.orthographic)
			{
				Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				this.BLLEFKOLKLP.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 654f;
			mousePosition.y -= (float)Screen.height * 1603f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			this.BLLEFKOLKLP.localPosition = mousePosition;
		}
	}

	// Token: 0x06000561 RID: 1377 RVA: 0x0004D7C0 File Offset: 0x0004B9C0
	public static void LLOHPLJBFMQ(BPLKJMJMHFI QKGJDCFCPMO, string QDDJBICKQIG)
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML)
		{
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.OKDFHDLPQEM(QKGJDCFCPMO);
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.OGQLCMOFLLQ(QDDJBICKQIG);
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.IQFQEOFBQKM();
			HCEEMKFECPJ.HBFFCJHOCPE.NLNIQPOMOGM();
		}
	}

	// Token: 0x06000562 RID: 1378 RVA: 0x00004305 File Offset: 0x00002505
	private void CBLIFECCHIC()
	{
		HCEEMKFECPJ.HBFFCJHOCPE = this;
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x0004D634 File Offset: 0x0004B834
	public static void GDIDEOLHDPI(BPLKJMJMHFI QKGJDCFCPMO, string QDDJBICKQIG)
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML)
		{
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.QKGJDCFCPMO = QKGJDCFCPMO;
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.KCLBMPFIPNQ = QDDJBICKQIG;
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.IQFQEOFBQKM();
			HCEEMKFECPJ.HBFFCJHOCPE.FKFEDINPBFF();
		}
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x0004D824 File Offset: 0x0004BA24
	private void QKLBGBKKGDG()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (this.CODFIINNNPG != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(mousePosition);
			if (this.CODFIINNNPG.orthographic)
			{
				Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				this.BLLEFKOLKLP.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 1929f;
			mousePosition.y -= (float)Screen.height * 1697f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			this.BLLEFKOLKLP.localPosition = mousePosition;
		}
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x00004289 File Offset: 0x00002489
	private void DHBEOHDMFDO()
	{
		HCEEMKFECPJ.HBFFCJHOCPE = null;
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x0004D94C File Offset: 0x0004BB4C
	public static void NKMQJHBCCJI(BPLKJMJMHFI QKGJDCFCPMO, string QDDJBICKQIG)
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML)
		{
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.QKGJDCFCPMO = QKGJDCFCPMO;
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.JOHBNEHCEJH(QDDJBICKQIG);
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.IQFQEOFBQKM();
			HCEEMKFECPJ.HBFFCJHOCPE.QDHNIMPGNOO();
		}
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x00004291 File Offset: 0x00002491
	public static void PFHOODNMELP()
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML != null)
		{
			HCEEMKFECPJ.LGHCHMIDGFO(HCEEMKFECPJ.HBFFCJHOCPE.JHIOGFKJMIN, HCEEMKFECPJ.HBFFCJHOCPE.PJQNBIONQQB);
		}
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x00004289 File Offset: 0x00002489
	private void JOLDGDIPFEC()
	{
		HCEEMKFECPJ.HBFFCJHOCPE = null;
	}

	// Token: 0x06000569 RID: 1385 RVA: 0x0004D9B0 File Offset: 0x0004BBB0
	private void PGFHJKDGEMJ()
	{
		this.BLLEFKOLKLP = base.transform;
		this.LNMJLFLDCML = base.GetComponentInChildren<PLQFPBQEPJD>();
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		if (this.LNMJLFLDCML != null)
		{
			this.JHIOGFKJMIN = this.LNMJLFLDCML.QKGJDCFCPMO;
			this.PJQNBIONQQB = this.LNMJLFLDCML.KCLBMPFIPNQ;
			if (this.LNMJLFLDCML.LGCLGHDGNPM < -4)
			{
				this.LNMJLFLDCML.LGCLGHDGNPM = 57;
			}
		}
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x0004DA48 File Offset: 0x0004BC48
	private void EHBDNIOCHNO()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (this.CODFIINNNPG != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(mousePosition);
			if (this.CODFIINNNPG.orthographic)
			{
				Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				this.BLLEFKOLKLP.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 916f;
			mousePosition.y -= (float)Screen.height * 225f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			this.BLLEFKOLKLP.localPosition = mousePosition;
		}
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x00004305 File Offset: 0x00002505
	private void OEOJDKBDNMJ()
	{
		HCEEMKFECPJ.HBFFCJHOCPE = this;
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x00004289 File Offset: 0x00002489
	private void HFNKLOHMQFH()
	{
		HCEEMKFECPJ.HBFFCJHOCPE = null;
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x0004DB70 File Offset: 0x0004BD70
	private void Update()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (this.CODFIINNNPG != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(mousePosition);
			if (this.CODFIINNNPG.orthographic)
			{
				Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				this.BLLEFKOLKLP.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 0.5f;
			mousePosition.y -= (float)Screen.height * 0.5f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			this.BLLEFKOLKLP.localPosition = mousePosition;
		}
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x0004DC98 File Offset: 0x0004BE98
	private void KPKQNOCFGIB()
	{
		this.BLLEFKOLKLP = base.transform;
		this.LNMJLFLDCML = base.GetComponentInChildren<PLQFPBQEPJD>();
		if (this.CODFIINNNPG == null)
		{
			this.CODFIINNNPG = IKBQNBHOJJB.FINJNKFMLMO(base.gameObject.layer);
		}
		if (this.LNMJLFLDCML != null)
		{
			this.JHIOGFKJMIN = this.LNMJLFLDCML.QKGJDCFCPMO;
			this.PJQNBIONQQB = this.LNMJLFLDCML.KCLBMPFIPNQ;
			if (this.LNMJLFLDCML.LGCLGHDGNPM < -43)
			{
				this.LNMJLFLDCML.LGCLGHDGNPM = 48;
			}
		}
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x00004289 File Offset: 0x00002489
	private void HMNFDLJGBIM()
	{
		HCEEMKFECPJ.HBFFCJHOCPE = null;
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x0004DD30 File Offset: 0x0004BF30
	public static void BLPNGMMJHNG(BPLKJMJMHFI QKGJDCFCPMO, string QDDJBICKQIG)
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML)
		{
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.OKDFHDLPQEM(QKGJDCFCPMO);
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.JOHBNEHCEJH(QDDJBICKQIG);
			HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML.IQFQEOFBQKM();
			HCEEMKFECPJ.HBFFCJHOCPE.NLNIQPOMOGM();
		}
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x0004DD94 File Offset: 0x0004BF94
	private void FKFEDINPBFF()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (this.CODFIINNNPG != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(mousePosition);
			if (this.CODFIINNNPG.orthographic)
			{
				Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				this.BLLEFKOLKLP.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 1421f;
			mousePosition.y -= (float)Screen.height * 1972f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			this.BLLEFKOLKLP.localPosition = mousePosition;
		}
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x0004DEBC File Offset: 0x0004C0BC
	private void QDHNIMPGNOO()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (this.CODFIINNNPG != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(mousePosition);
			if (this.CODFIINNNPG.orthographic)
			{
				Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				this.BLLEFKOLKLP.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 548f;
			mousePosition.y -= (float)Screen.height * 1741f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			this.BLLEFKOLKLP.localPosition = mousePosition;
		}
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x0004DFE4 File Offset: 0x0004C1E4
	private void PIQDBCGQDCH()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (this.CODFIINNNPG != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(mousePosition);
			if (this.CODFIINNNPG.orthographic)
			{
				Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				this.BLLEFKOLKLP.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 1237f;
			mousePosition.y -= (float)Screen.height * 2f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			this.BLLEFKOLKLP.localPosition = mousePosition;
		}
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x00004289 File Offset: 0x00002489
	private void QJELMIKNIIE()
	{
		HCEEMKFECPJ.HBFFCJHOCPE = null;
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x0004E10C File Offset: 0x0004C30C
	private void QIHJCOLPLBQ()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (this.CODFIINNNPG != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(mousePosition);
			if (this.CODFIINNNPG.orthographic)
			{
				Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				this.BLLEFKOLKLP.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 1970f;
			mousePosition.y -= (float)Screen.height * 637f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			this.BLLEFKOLKLP.localPosition = mousePosition;
		}
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x0004E234 File Offset: 0x0004C434
	private void NLNIQPOMOGM()
	{
		Vector3 mousePosition = Input.mousePosition;
		if (this.CODFIINNNPG != null)
		{
			mousePosition.x = Mathf.Clamp01(mousePosition.x / (float)Screen.width);
			mousePosition.y = Mathf.Clamp01(mousePosition.y / (float)Screen.height);
			this.BLLEFKOLKLP.position = this.CODFIINNNPG.ViewportToWorldPoint(mousePosition);
			if (this.CODFIINNNPG.orthographic)
			{
				Vector3 localPosition = this.BLLEFKOLKLP.localPosition;
				localPosition.x = Mathf.Round(localPosition.x);
				localPosition.y = Mathf.Round(localPosition.y);
				this.BLLEFKOLKLP.localPosition = localPosition;
			}
		}
		else
		{
			mousePosition.x -= (float)Screen.width * 1463f;
			mousePosition.y -= (float)Screen.height * 1342f;
			mousePosition.x = Mathf.Round(mousePosition.x);
			mousePosition.y = Mathf.Round(mousePosition.y);
			this.BLLEFKOLKLP.localPosition = mousePosition;
		}
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x0000424F File Offset: 0x0000244F
	public static void CLGQKEPDEQI()
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML != null)
		{
			HCEEMKFECPJ.BLPNGMMJHNG(HCEEMKFECPJ.HBFFCJHOCPE.JHIOGFKJMIN, HCEEMKFECPJ.HBFFCJHOCPE.PJQNBIONQQB);
		}
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x00004215 File Offset: 0x00002415
	public static void FQIMQLKCNGM()
	{
		if (HCEEMKFECPJ.HBFFCJHOCPE != null && HCEEMKFECPJ.HBFFCJHOCPE.LNMJLFLDCML != null)
		{
			HCEEMKFECPJ.PJMIKDIEGMB(HCEEMKFECPJ.HBFFCJHOCPE.JHIOGFKJMIN, HCEEMKFECPJ.HBFFCJHOCPE.PJQNBIONQQB);
		}
	}

	// Token: 0x040000A6 RID: 166
	public static HCEEMKFECPJ HBFFCJHOCPE;

	// Token: 0x040000A7 RID: 167
	public Camera CODFIINNNPG;

	// Token: 0x040000A8 RID: 168
	private Transform BLLEFKOLKLP;

	// Token: 0x040000A9 RID: 169
	private PLQFPBQEPJD LNMJLFLDCML;

	// Token: 0x040000AA RID: 170
	private BPLKJMJMHFI JHIOGFKJMIN;

	// Token: 0x040000AB RID: 171
	private string PJQNBIONQQB;
}
