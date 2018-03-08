using System;
using NUnit.Framework;
using UnityEngine;

namespace Lib
{
    public class Hinge
    {
        private GameObject gameObject;
        private RangeInt range;
        private Vector3 direction;
        private float angularVelocity;
        
        public Hinge(GameObject gameObject, Vector3 direction,  RangeInt range, float angularVelocity)
        {
            this.gameObject = gameObject;
            this.direction = direction;
            this.range = range;
            this.angularVelocity = angularVelocity;
        }

        public void moveTo(float degree)
        {
            var currentAngle = getComponentOfVector3(gameObject.transform.localEulerAngles, direction);
            var distance = (clamp((degree + 360) % 360, range.start, range.length) - currentAngle) % 360;
            var dAngle = clamp(distance, -angularVelocity * Time.deltaTime, angularVelocity * Time.deltaTime);
            if (Math.Abs(dAngle) > 0.01)
            {
                gameObject.transform.Rotate(direction, dAngle);
            }
        }

        private float clamp(float val, float min, float max)
        {
            if (val < min)
                return min;
            else if (val > max)
                return max;
            else return val;
        }

        private float getComponentOfVector3(Vector3 vector, Vector3 d)
        {
            return new Vector3(
                vector.x * d.x,
                vector.y * d.y,
                vector.z * d.z).magnitude;
        }
    }
}