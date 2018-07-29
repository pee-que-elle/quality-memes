using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000199 RID: 409
public class GKGFHHOBPKH : MonoBehaviour
{
	// Token: 0x0600335E RID: 13150 RVA: 0x00002300 File Offset: 0x00000500
	private void OLLNOFNEEIL()
	{
	}

	// Token: 0x0600335F RID: 13151 RVA: 0x00002300 File Offset: 0x00000500
	private void Start()
	{
	}

	// Token: 0x06003360 RID: 13152 RVA: 0x00002300 File Offset: 0x00000500
	private void CIJOENOQKCI()
	{
	}

	// Token: 0x06003361 RID: 13153 RVA: 0x00002300 File Offset: 0x00000500
	private void JDLQNCEDMPI()
	{
	}

	// Token: 0x06003362 RID: 13154 RVA: 0x00186D1C File Offset: 0x00184F1C
	public IEnumerator KBHNBDNKKLF(int CIQJPPPKQPM, Transform IHFGQHCKOFK, bool QOOOEFQKIMO = false)
	{
		if (CIQJPPPKQPM == 0)
		{
			CIQJPPPKQPM = 1;
		}
		Vector3 vector = new Vector3(IHFGQHCKOFK.localScale.x, IHFGQHCKOFK.localScale.y, IHFGQHCKOFK.localScale.z);
		KGQECFKLKOP.NHDNHHGJDHG jblcjclqgcj = OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ;
		OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.HitFoe;
		this.ELNPMJEJDLQ.Play("Pokeball_Open_Catch");
		yield return new WaitForSeconds(0.1f);
		return 1;
		base.transform.position = IHFGQHCKOFK.position + new Vector3(1.5f, 3f, 1f);
		base.transform.eulerAngles = new Vector3(0f, -140f, 0f);
		this.QOHPOCICCNN.SetActive(true);
		yield return new WaitForSeconds(1f);
		return 1;
		this.PFDDIDGEJII.transform.position = IHFGQHCKOFK.position + new Vector3(0f, 0.8f, 0f);
		this.PFDDIDGEJII.SetActive(true);
		yield return new WaitForSeconds(0.3f);
		return 1;
		DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(23, false);
		FPMCQNCDOIP.FJCEGFKJLCL(IHFGQHCKOFK.gameObject, 0.3f, Vector3.zero);
		yield return new WaitForSeconds(0.31f);
		return 1;
		IHFGQHCKOFK.localScale = Vector3.zero;
		if (this.ELNPMJEJDLQ.isPlaying)
		{
			goto IL_27B;
		}
		int num = 0;
		goto IL_2A7;
		IL_27B:
		yield return null;
		return 1;
		num++;
		IL_2A7:
		if (num < CIQJPPPKQPM)
		{
			goto IL_33B;
		}
		if (QOOOEFQKIMO)
		{
			goto IL_2FD;
		}
		this.ELNPMJEJDLQ.Play("Pokeball_Break");
		yield return new WaitForSeconds(0.1f);
		return 1;
		IL_2FD:
		this.ELNPMJEJDLQ.Play("Pokeball_Success");
		yield return new WaitForSeconds(0.8f);
		return 1;
		IL_33B:
		this.ELNPMJEJDLQ.Play("Pokeball_Shake");
		DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(22, false);
		if (this.ELNPMJEJDLQ.isPlaying)
		{
			goto IL_397;
		}
		yield return new WaitForSeconds(0.2f);
		return 1;
		IL_397:
		yield return null;
		return 1;
		this.DDNIGNHCEIH.transform.position = IHFGQHCKOFK.position + new Vector3(0f, 0.8f, 0f);
		this.DDNIGNHCEIH.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		return 1;
		FPMCQNCDOIP.FJCEGFKJLCL(IHFGQHCKOFK.gameObject, 0.3f, vector);
		yield return new WaitForSeconds(0.31f);
		return 1;
		IHFGQHCKOFK.localScale = vector;
		yield return new WaitForSeconds(0.3f);
		return 1;
		OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ = jblcjclqgcj;
		UnityEngine.Object.Destroy(base.gameObject);
		IHFGQHCKOFK.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(0, false, IHFGQHCKOFK.transform.position, IHFGQHCKOFK.transform.localEulerAngles, null, "M");
		IHFGQHCKOFK.transform.localScale = new Vector3(0.015f, 0.02f, 0.02f);
		yield break;
		if (this.ELNPMJEJDLQ.isPlaying)
		{
			goto IL_56D;
		}
		OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ = jblcjclqgcj;
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		return 1;
		IL_56D:
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06003363 RID: 13155 RVA: 0x00186D1C File Offset: 0x00184F1C
	public IEnumerator ODMOJLIJOIK(int CIQJPPPKQPM, Transform IHFGQHCKOFK, bool QOOOEFQKIMO = false)
	{
		if (CIQJPPPKQPM == 0)
		{
			CIQJPPPKQPM = 1;
		}
		vector = new Vector3(IHFGQHCKOFK.localScale.x, IHFGQHCKOFK.localScale.y, IHFGQHCKOFK.localScale.z);
		jblcjclqgcj = OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ;
		OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.HitFoe;
		this.ELNPMJEJDLQ.Play("Pokeball_Open_Catch");
		yield return new WaitForSeconds(0.1f);
		return 1;
		base.transform.position = IHFGQHCKOFK.position + new Vector3(1.5f, 3f, 1f);
		base.transform.eulerAngles = new Vector3(0f, -140f, 0f);
		this.QOHPOCICCNN.SetActive(true);
		yield return new WaitForSeconds(1f);
		return 1;
		this.PFDDIDGEJII.transform.position = IHFGQHCKOFK.position + new Vector3(0f, 0.8f, 0f);
		this.PFDDIDGEJII.SetActive(true);
		yield return new WaitForSeconds(0.3f);
		return 1;
		DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(23, false);
		FPMCQNCDOIP.FJCEGFKJLCL(IHFGQHCKOFK.gameObject, 0.3f, Vector3.zero);
		yield return new WaitForSeconds(0.31f);
		return 1;
		IHFGQHCKOFK.localScale = Vector3.zero;
		if (this.ELNPMJEJDLQ.isPlaying)
		{
			goto IL_27B;
		}
		num = 0;
		goto IL_2A7;
		IL_27B:
		yield return null;
		return 1;
		num++;
		IL_2A7:
		if (num < CIQJPPPKQPM)
		{
			goto IL_33B;
		}
		if (QOOOEFQKIMO)
		{
			goto IL_2FD;
		}
		this.ELNPMJEJDLQ.Play("Pokeball_Break");
		yield return new WaitForSeconds(0.1f);
		return 1;
		IL_2FD:
		this.ELNPMJEJDLQ.Play("Pokeball_Success");
		yield return new WaitForSeconds(0.8f);
		return 1;
		IL_33B:
		this.ELNPMJEJDLQ.Play("Pokeball_Shake");
		DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(22, false);
		if (this.ELNPMJEJDLQ.isPlaying)
		{
			goto IL_397;
		}
		yield return new WaitForSeconds(0.2f);
		return 1;
		IL_397:
		yield return null;
		return 1;
		this.DDNIGNHCEIH.transform.position = IHFGQHCKOFK.position + new Vector3(0f, 0.8f, 0f);
		this.DDNIGNHCEIH.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		return 1;
		FPMCQNCDOIP.FJCEGFKJLCL(IHFGQHCKOFK.gameObject, 0.3f, vector);
		yield return new WaitForSeconds(0.31f);
		return 1;
		IHFGQHCKOFK.localScale = vector;
		yield return new WaitForSeconds(0.3f);
		return 1;
		OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ = jblcjclqgcj;
		UnityEngine.Object.Destroy(base.gameObject);
		IHFGQHCKOFK.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(0, false, IHFGQHCKOFK.transform.position, IHFGQHCKOFK.transform.localEulerAngles, null, "M");
		IHFGQHCKOFK.transform.localScale = new Vector3(0.015f, 0.02f, 0.02f);
		yield break;
		if (this.ELNPMJEJDLQ.isPlaying)
		{
			goto IL_56D;
		}
		OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ = jblcjclqgcj;
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		return 1;
		IL_56D:
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06003364 RID: 13156 RVA: 0x00002300 File Offset: 0x00000500
	private void QBGOGFJCLEP()
	{
	}

	// Token: 0x06003365 RID: 13157 RVA: 0x00002300 File Offset: 0x00000500
	private void LMMGEGJCBJP()
	{
	}

	// Token: 0x06003366 RID: 13158 RVA: 0x00186D1C File Offset: 0x00184F1C
	public IEnumerator CPOHKILFDEQ(int CIQJPPPKQPM, Transform IHFGQHCKOFK, bool QOOOEFQKIMO = false)
	{
		if (CIQJPPPKQPM == 0)
		{
			CIQJPPPKQPM = 1;
		}
		vector = new Vector3(IHFGQHCKOFK.localScale.x, IHFGQHCKOFK.localScale.y, IHFGQHCKOFK.localScale.z);
		jblcjclqgcj = OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ;
		OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.HitFoe;
		this.ELNPMJEJDLQ.Play("Pokeball_Open_Catch");
		yield return new WaitForSeconds(0.1f);
		return 1;
		base.transform.position = IHFGQHCKOFK.position + new Vector3(1.5f, 3f, 1f);
		base.transform.eulerAngles = new Vector3(0f, -140f, 0f);
		this.QOHPOCICCNN.SetActive(true);
		yield return new WaitForSeconds(1f);
		return 1;
		this.PFDDIDGEJII.transform.position = IHFGQHCKOFK.position + new Vector3(0f, 0.8f, 0f);
		this.PFDDIDGEJII.SetActive(true);
		yield return new WaitForSeconds(0.3f);
		return 1;
		DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(23, false);
		FPMCQNCDOIP.FJCEGFKJLCL(IHFGQHCKOFK.gameObject, 0.3f, Vector3.zero);
		yield return new WaitForSeconds(0.31f);
		return 1;
		IHFGQHCKOFK.localScale = Vector3.zero;
		if (this.ELNPMJEJDLQ.isPlaying)
		{
			goto IL_27B;
		}
		num = 0;
		goto IL_2A7;
		IL_27B:
		yield return null;
		return 1;
		num++;
		IL_2A7:
		if (num < CIQJPPPKQPM)
		{
			goto IL_33B;
		}
		if (QOOOEFQKIMO)
		{
			goto IL_2FD;
		}
		this.ELNPMJEJDLQ.Play("Pokeball_Break");
		yield return new WaitForSeconds(0.1f);
		return 1;
		IL_2FD:
		this.ELNPMJEJDLQ.Play("Pokeball_Success");
		yield return new WaitForSeconds(0.8f);
		return 1;
		IL_33B:
		this.ELNPMJEJDLQ.Play("Pokeball_Shake");
		DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(22, false);
		if (this.ELNPMJEJDLQ.isPlaying)
		{
			goto IL_397;
		}
		yield return new WaitForSeconds(0.2f);
		return 1;
		IL_397:
		yield return null;
		return 1;
		this.DDNIGNHCEIH.transform.position = IHFGQHCKOFK.position + new Vector3(0f, 0.8f, 0f);
		this.DDNIGNHCEIH.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		return 1;
		FPMCQNCDOIP.FJCEGFKJLCL(IHFGQHCKOFK.gameObject, 0.3f, vector);
		yield return new WaitForSeconds(0.31f);
		return 1;
		IHFGQHCKOFK.localScale = vector;
		yield return new WaitForSeconds(0.3f);
		return 1;
		OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ = jblcjclqgcj;
		UnityEngine.Object.Destroy(base.gameObject);
		IHFGQHCKOFK.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(0, false, IHFGQHCKOFK.transform.position, IHFGQHCKOFK.transform.localEulerAngles, null, "M");
		IHFGQHCKOFK.transform.localScale = new Vector3(0.015f, 0.02f, 0.02f);
		yield break;
		if (this.ELNPMJEJDLQ.isPlaying)
		{
			goto IL_56D;
		}
		OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ = jblcjclqgcj;
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		return 1;
		IL_56D:
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06003367 RID: 13159 RVA: 0x00186D1C File Offset: 0x00184F1C
	public IEnumerator JJNOGBQGHJC(int CIQJPPPKQPM, Transform IHFGQHCKOFK, bool QOOOEFQKIMO = false)
	{
		if (CIQJPPPKQPM == 0)
		{
			CIQJPPPKQPM = 1;
		}
		vector = new Vector3(IHFGQHCKOFK.localScale.x, IHFGQHCKOFK.localScale.y, IHFGQHCKOFK.localScale.z);
		jblcjclqgcj = OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ;
		OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.HitFoe;
		this.ELNPMJEJDLQ.Play("Pokeball_Open_Catch");
		yield return new WaitForSeconds(0.1f);
		return 1;
		base.transform.position = IHFGQHCKOFK.position + new Vector3(1.5f, 3f, 1f);
		base.transform.eulerAngles = new Vector3(0f, -140f, 0f);
		this.QOHPOCICCNN.SetActive(true);
		yield return new WaitForSeconds(1f);
		return 1;
		this.PFDDIDGEJII.transform.position = IHFGQHCKOFK.position + new Vector3(0f, 0.8f, 0f);
		this.PFDDIDGEJII.SetActive(true);
		yield return new WaitForSeconds(0.3f);
		return 1;
		DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(23, false);
		FPMCQNCDOIP.FJCEGFKJLCL(IHFGQHCKOFK.gameObject, 0.3f, Vector3.zero);
		yield return new WaitForSeconds(0.31f);
		return 1;
		IHFGQHCKOFK.localScale = Vector3.zero;
		if (this.ELNPMJEJDLQ.isPlaying)
		{
			goto IL_27B;
		}
		num = 0;
		goto IL_2A7;
		IL_27B:
		yield return null;
		return 1;
		num++;
		IL_2A7:
		if (num < CIQJPPPKQPM)
		{
			goto IL_33B;
		}
		if (QOOOEFQKIMO)
		{
			goto IL_2FD;
		}
		this.ELNPMJEJDLQ.Play("Pokeball_Break");
		yield return new WaitForSeconds(0.1f);
		return 1;
		IL_2FD:
		this.ELNPMJEJDLQ.Play("Pokeball_Success");
		yield return new WaitForSeconds(0.8f);
		return 1;
		IL_33B:
		this.ELNPMJEJDLQ.Play("Pokeball_Shake");
		DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(22, false);
		if (this.ELNPMJEJDLQ.isPlaying)
		{
			goto IL_397;
		}
		yield return new WaitForSeconds(0.2f);
		return 1;
		IL_397:
		yield return null;
		return 1;
		this.DDNIGNHCEIH.transform.position = IHFGQHCKOFK.position + new Vector3(0f, 0.8f, 0f);
		this.DDNIGNHCEIH.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		return 1;
		FPMCQNCDOIP.FJCEGFKJLCL(IHFGQHCKOFK.gameObject, 0.3f, vector);
		yield return new WaitForSeconds(0.31f);
		return 1;
		IHFGQHCKOFK.localScale = vector;
		yield return new WaitForSeconds(0.3f);
		return 1;
		OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ = jblcjclqgcj;
		UnityEngine.Object.Destroy(base.gameObject);
		IHFGQHCKOFK.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(0, false, IHFGQHCKOFK.transform.position, IHFGQHCKOFK.transform.localEulerAngles, null, "M");
		IHFGQHCKOFK.transform.localScale = new Vector3(0.015f, 0.02f, 0.02f);
		yield break;
		if (this.ELNPMJEJDLQ.isPlaying)
		{
			goto IL_56D;
		}
		OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ = jblcjclqgcj;
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		return 1;
		IL_56D:
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x06003368 RID: 13160 RVA: 0x00186D1C File Offset: 0x00184F1C
	public IEnumerator JDLOGQFIQJJ(int CIQJPPPKQPM, Transform IHFGQHCKOFK, bool QOOOEFQKIMO = false)
	{
		if (CIQJPPPKQPM == 0)
		{
			CIQJPPPKQPM = 1;
		}
		vector = new Vector3(IHFGQHCKOFK.localScale.x, IHFGQHCKOFK.localScale.y, IHFGQHCKOFK.localScale.z);
		jblcjclqgcj = OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ;
		OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ = KGQECFKLKOP.NHDNHHGJDHG.HitFoe;
		this.ELNPMJEJDLQ.Play("Pokeball_Open_Catch");
		yield return new WaitForSeconds(0.1f);
		return 1;
		base.transform.position = IHFGQHCKOFK.position + new Vector3(1.5f, 3f, 1f);
		base.transform.eulerAngles = new Vector3(0f, -140f, 0f);
		this.QOHPOCICCNN.SetActive(true);
		yield return new WaitForSeconds(1f);
		return 1;
		this.PFDDIDGEJII.transform.position = IHFGQHCKOFK.position + new Vector3(0f, 0.8f, 0f);
		this.PFDDIDGEJII.SetActive(true);
		yield return new WaitForSeconds(0.3f);
		return 1;
		DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(23, false);
		FPMCQNCDOIP.FJCEGFKJLCL(IHFGQHCKOFK.gameObject, 0.3f, Vector3.zero);
		yield return new WaitForSeconds(0.31f);
		return 1;
		IHFGQHCKOFK.localScale = Vector3.zero;
		if (this.ELNPMJEJDLQ.isPlaying)
		{
			goto IL_27B;
		}
		num = 0;
		goto IL_2A7;
		IL_27B:
		yield return null;
		return 1;
		num++;
		IL_2A7:
		if (num < CIQJPPPKQPM)
		{
			goto IL_33B;
		}
		if (QOOOEFQKIMO)
		{
			goto IL_2FD;
		}
		this.ELNPMJEJDLQ.Play("Pokeball_Break");
		yield return new WaitForSeconds(0.1f);
		return 1;
		IL_2FD:
		this.ELNPMJEJDLQ.Play("Pokeball_Success");
		yield return new WaitForSeconds(0.8f);
		return 1;
		IL_33B:
		this.ELNPMJEJDLQ.Play("Pokeball_Shake");
		DCCFQPDFBFO.QOQONHOOLNE.LKHCJLDFLEJ(22, false);
		if (this.ELNPMJEJDLQ.isPlaying)
		{
			goto IL_397;
		}
		yield return new WaitForSeconds(0.2f);
		return 1;
		IL_397:
		yield return null;
		return 1;
		this.DDNIGNHCEIH.transform.position = IHFGQHCKOFK.position + new Vector3(0f, 0.8f, 0f);
		this.DDNIGNHCEIH.SetActive(true);
		yield return new WaitForSeconds(0.2f);
		return 1;
		FPMCQNCDOIP.FJCEGFKJLCL(IHFGQHCKOFK.gameObject, 0.3f, vector);
		yield return new WaitForSeconds(0.31f);
		return 1;
		IHFGQHCKOFK.localScale = vector;
		yield return new WaitForSeconds(0.3f);
		return 1;
		OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ = jblcjclqgcj;
		UnityEngine.Object.Destroy(base.gameObject);
		IHFGQHCKOFK.GetComponent<FINHCKBDLMF>().BQLIIQIIMDH(0, false, IHFGQHCKOFK.transform.position, IHFGQHCKOFK.transform.localEulerAngles, null, "M");
		IHFGQHCKOFK.transform.localScale = new Vector3(0.015f, 0.02f, 0.02f);
		yield break;
		if (this.ELNPMJEJDLQ.isPlaying)
		{
			goto IL_56D;
		}
		OGJJKKQPNMK.QOQONHOOLNE.JBLCJCLQGCJ = jblcjclqgcj;
		UnityEngine.Object.Destroy(base.gameObject);
		yield return null;
		return 1;
		IL_56D:
		yield return null;
		return 1;
		yield break;
	}

	// Token: 0x04000BD0 RID: 3024
	public GameObject PFDDIDGEJII;

	// Token: 0x04000BD1 RID: 3025
	public GameObject DDNIGNHCEIH;

	// Token: 0x04000BD2 RID: 3026
	public GameObject QOHPOCICCNN;

	// Token: 0x04000BD3 RID: 3027
	public Animation ELNPMJEJDLQ;
}
