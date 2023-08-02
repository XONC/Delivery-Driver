using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
   [SerializeField] Color32 hasPackageColor = new Color32(25,207,64,255);
   [SerializeField] Color32 noPackageColor = new Color32(255,255,255,255);
   [SerializeField] float destroyDelay = 0.5f;
   bool hasPackage = false;
   SpriteRenderer spriteRenderer;
   
   private void Start() {
      spriteRenderer = GetComponent<SpriteRenderer>(); // 获取应用此脚本的spriteRenderer对象
      spriteRenderer.color = noPackageColor;
   }

   private void OnCollisionEnter2D(Collision2D other) {
    Debug.Log(other);
   }

   private void OnTriggerEnter2D(Collider2D other) {
      if(other.tag == "Package" && !hasPackage) {
         hasPackage = true;
         spriteRenderer.color = hasPackageColor;
         Destroy(other.gameObject,destroyDelay);
      }

      if(other.tag == "Customer" && hasPackage) {
         spriteRenderer.color = noPackageColor;
         hasPackage = false;
      }
   }
}
