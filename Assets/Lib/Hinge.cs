using System;
using UnityEngine;

namespace Lib
{
    public class Hinge
    {
        private GameObject gameObject;
        private RangeInt range;
        private Vector3 direction;
        private float angularVelocity;
        private bool rangeLimited;

        public Hinge(GameObject gameObject, Vector3 direction, RangeInt range, float angularVelocity)
        {
            this.gameObject = gameObject;
            this.direction = direction;
            this.range = range;
            this.angularVelocity = angularVelocity;
            rangeLimited = (range.length - range.start) < 360;
        }

        public void moveTo(float degree)
        {
            var currentAngle = getDirectionComponentOfVector3(gameObject.transform.localEulerAngles);
            float deg;
            float distance;
            if (rangeLimited) {
                deg = degree;
                if (!withinRange(degree, range.start, range.length)) {
                    Debug.Log(String.Format("Degree is out of range! {0}, range: {1}:{2}", degree, range.start, range.length));
                    // Find closest to the point you can get.
                    if (Math.Abs(degree - range.start) > Math.Abs(degree - range.length)) {
                        deg = range.length;
                    } else {
                        deg = range.start;
                    }
                }

                distance = (deg - currentAngle);
                // Loop around if the range is looping past 360
                if (range.start > range.length && distance > 180){
                    distance -= 360;
                }
            } else {
                deg = (degree + 360) % 360;
                distance = (deg - currentAngle);
                if (distance > 180)
                    distance -= 360;
            }
            
            var dAngle = clamp(distance, -angularVelocity * Time.deltaTime, angularVelocity * Time.deltaTime);
            if (Math.Abs(dAngle) > 0.01) {
                gameObject.transform.Rotate(direction, dAngle);
            }
        }

        private bool withinRange(float val, float min, float max)
        {
            if (min > max)
                return val >= min || val <= max;
            else
                return val >= min && val <= max;
        }

        private float clamp(float val, float min, float max)
        {
            if (val < min)
                return min;
            else if (val > max)
                return max;
            else return val;
        }

        private float getDirectionComponentOfVector3(Vector3 vector)
        {
            return new Vector3(
                vector.x * direction.x,
                vector.y * direction.y,
                vector.z * direction.z).magnitude;
        }
    }
}