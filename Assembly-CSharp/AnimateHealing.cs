using System;
using UnityEngine;

// Token: 0x02000136 RID: 310
public class AnimateHealing : MonoBehaviour
{
	// Token: 0x060024B0 RID: 9392 RVA: 0x000EF2CC File Offset: 0x000ED4CC
	private void Start()
	{
		QOHCEBMQKMB.QOQONHOOLNE.BKGHEHPPPMH.Add(this);
		this.rend = base.GetComponentInChildren<Renderer>();
		this.rend.material.color = Color.black;
		this.Balls = UnityEngine.Object.Instantiate<GameObject>(this.HealPrefab, base.transform).GetComponent<HealingBalls>();
		if (this.CenterMachine)
		{
			this.Balls.transform.position += new Vector3(2.15f, 0f, 0f);
		}
		this.Balls.Hide();
	}

	// Token: 0x060024B1 RID: 9393 RVA: 0x00013741 File Offset: 0x00011941
	public void Heal(int amount)
	{
		base.CancelInvoke("Stop");
		this.blackness = 0f;
		this.Healing = true;
		this.Balls.Show(amount);
		base.Invoke("Stop", 2.5f);
	}

	// Token: 0x060024B2 RID: 9394 RVA: 0x000EF368 File Offset: 0x000ED568
	private void Update()
	{
		this.offset = Time.time * this.scrollSpeed;
		if (!this.DifferentAxis)
		{
			this.rend.material.SetTextureOffset("_MainTex", new Vector2(0f, this.offset));
		}
		else
		{
			this.rend.material.SetTextureOffset("_MainTex", new Vector2(this.offset, 0f));
		}
		if (this.Healing)
		{
			this.rend.material.color = Color.Lerp(Color.black, Color.white, this.blackness);
			this.blackness += Time.deltaTime;
		}
		else if (this.rend.material.color != Color.black)
		{
			this.blackness += Time.deltaTime;
			this.rend.material.color = Color.Lerp(Color.white, Color.black, this.blackness);
		}
	}

	// Token: 0x060024B3 RID: 9395 RVA: 0x0001377C File Offset: 0x0001197C
	private void Stop()
	{
		this.Healing = false;
		this.blackness = 0f;
	}

	// Token: 0x040007DE RID: 2014
	public GameObject HealPrefab;

	// Token: 0x040007DF RID: 2015
	private HealingBalls Balls;

	// Token: 0x040007E0 RID: 2016
	public bool CenterMachine;

	// Token: 0x040007E1 RID: 2017
	public bool Healing;

	// Token: 0x040007E2 RID: 2018
	private float scrollSpeed = -1f;

	// Token: 0x040007E3 RID: 2019
	private bool DifferentAxis;

	// Token: 0x040007E4 RID: 2020
	public Renderer rend;

	// Token: 0x040007E5 RID: 2021
	private float offset;

	// Token: 0x040007E6 RID: 2022
	private float blackness;
}
