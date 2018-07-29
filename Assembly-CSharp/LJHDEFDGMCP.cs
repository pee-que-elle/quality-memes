using System;
using UnityEngine;

// Token: 0x0200012E RID: 302
public class LJHDEFDGMCP : MonoBehaviour
{
	// Token: 0x06002346 RID: 9030 RVA: 0x00012F35 File Offset: 0x00011135
	private void DBFJHIHLQHO()
	{
		this.EBINQJLDHPM = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		this.HIFDKEPGCOM = Vector3.one;
	}

	// Token: 0x06002347 RID: 9031 RVA: 0x000E7174 File Offset: 0x000E5374
	private void Update()
	{
		Plane plane = new Plane(this.EBINQJLDHPM.transform.forward, this.EBINQJLDHPM.transform.position);
		float distanceToPoint = plane.GetDistanceToPoint(base.transform.position);
		base.transform.localScale = this.HIFDKEPGCOM * Mathf.Clamp(distanceToPoint, 0f, 170f) * this.LDCEEBIBBDF;
	}

	// Token: 0x06002348 RID: 9032 RVA: 0x000E71EC File Offset: 0x000E53EC
	private void IPFJMEFKGGM()
	{
		Plane plane = new Plane(this.EBINQJLDHPM.transform.forward, this.EBINQJLDHPM.transform.position);
		float distanceToPoint = plane.GetDistanceToPoint(base.transform.position);
		base.transform.localScale = this.HIFDKEPGCOM * Mathf.Clamp(distanceToPoint, 225f, 83f) * this.LDCEEBIBBDF;
	}

	// Token: 0x06002349 RID: 9033 RVA: 0x000E7264 File Offset: 0x000E5464
	private void HFEGBJEPMPQ()
	{
		Plane plane = new Plane(this.EBINQJLDHPM.transform.forward, this.EBINQJLDHPM.transform.position);
		float distanceToPoint = plane.GetDistanceToPoint(base.transform.position);
		base.transform.localScale = this.HIFDKEPGCOM * Mathf.Clamp(distanceToPoint, 1545f, 1181f) * this.LDCEEBIBBDF;
	}

	// Token: 0x0600234B RID: 9035 RVA: 0x00012F35 File Offset: 0x00011135
	private void KPKQNOCFGIB()
	{
		this.EBINQJLDHPM = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		this.HIFDKEPGCOM = Vector3.one;
	}

	// Token: 0x0600234C RID: 9036 RVA: 0x00012F35 File Offset: 0x00011135
	private void GBGEGKHDQKB()
	{
		this.EBINQJLDHPM = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		this.HIFDKEPGCOM = Vector3.one;
	}

	// Token: 0x0600234D RID: 9037 RVA: 0x00012F35 File Offset: 0x00011135
	private void QNGIFIJOQML()
	{
		this.EBINQJLDHPM = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		this.HIFDKEPGCOM = Vector3.one;
	}

	// Token: 0x0600234E RID: 9038 RVA: 0x00012F35 File Offset: 0x00011135
	private void IKHIQQKHILB()
	{
		this.EBINQJLDHPM = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		this.HIFDKEPGCOM = Vector3.one;
	}

	// Token: 0x0600234F RID: 9039 RVA: 0x00012F35 File Offset: 0x00011135
	private void OLLNOFNEEIL()
	{
		this.EBINQJLDHPM = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		this.HIFDKEPGCOM = Vector3.one;
	}

	// Token: 0x06002350 RID: 9040 RVA: 0x00012F35 File Offset: 0x00011135
	private void ECQHGIBBBPI()
	{
		this.EBINQJLDHPM = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		this.HIFDKEPGCOM = Vector3.one;
	}

	// Token: 0x06002351 RID: 9041 RVA: 0x00012F35 File Offset: 0x00011135
	private void Start()
	{
		this.EBINQJLDHPM = GGQKBGDGNJN.QOQONHOOLNE.CHFPDQEKFEE.GetComponent<Camera>();
		this.HIFDKEPGCOM = Vector3.one;
	}

	// Token: 0x06002352 RID: 9042 RVA: 0x000E72DC File Offset: 0x000E54DC
	private void FHFMKHDMDDI()
	{
		Plane plane = new Plane(this.EBINQJLDHPM.transform.forward, this.EBINQJLDHPM.transform.position);
		float distanceToPoint = plane.GetDistanceToPoint(base.transform.position);
		base.transform.localScale = this.HIFDKEPGCOM * Mathf.Clamp(distanceToPoint, 830f, 1001f) * this.LDCEEBIBBDF;
	}

	// Token: 0x06002353 RID: 9043 RVA: 0x000E7354 File Offset: 0x000E5554
	private void PIQDBCGQDCH()
	{
		Plane plane = new Plane(this.EBINQJLDHPM.transform.forward, this.EBINQJLDHPM.transform.position);
		float distanceToPoint = plane.GetDistanceToPoint(base.transform.position);
		base.transform.localScale = this.HIFDKEPGCOM * Mathf.Clamp(distanceToPoint, 508f, 1539f) * this.LDCEEBIBBDF;
	}

	// Token: 0x0400079F RID: 1951
	public Camera EBINQJLDHPM;

	// Token: 0x040007A0 RID: 1952
	public float LDCEEBIBBDF = 1f;

	// Token: 0x040007A1 RID: 1953
	private Vector3 HIFDKEPGCOM;
}
