using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;
using System;

public class Person
{
    public static List<Person> people;

    static float MULTIPLIER_STR, MULTIPLIER_AGI, MULTIPLIER_INT, MULTIPLIER_CHA;

    public string firstName;
    public string lastName;
    public DateTime birthDate;
    public Tile location;

    public int Strength = 3;
    public int Agility = 3;
    public int Intelligence = 3;
    public int Charisma = 3;

    float melee = 0;
    float shooting = 0;
    float foraging = 0;
    float construction = 0;
    float riding = 0;
    float driving = 0;
    float stamina = 0;
    float running = 0;
    float treatment = 0;
    float science = 0;
    float crafting = 0;
    float leadership = 0;
    float prisonManagement = 0;
    float lawmaking = 0;
    float persuasion = 0;
    float intimidation = 0;
    float facilityManagement = 0;
    float herding = 0;

    public Person(string firstName, string lastName, DateTime birthDate, Tile location)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthDate = birthDate;
        this.location = location;

        people.Add(this);
    }

    public float Melee
    {
        get
        {
            return melee + Strength;
        }

        set
        {
            melee = value;
        }
    }

    public float Shooting
    {
        get
        {
            return shooting + (Strength + Agility) / 2;
        }

        set
        {
            shooting = value;
        }
    }

    public float Foraging
    {
        get
        {
            return foraging + (Intelligence + Agility) / 2;
        }

        set
        {
            foraging = value;
        }
    }

    public float Construction
    {
        get
        {
            return construction + (Strength + Intelligence) / 2;
        }

        set
        {
            construction = value;
        }
    }

    public float Riding
    {
        get
        {
            return riding + Agility;
        }

        set
        {
            riding = value;
        }
    }

    public float Driving
    {
        get
        {
            return driving + Agility;
        }

        set
        {
            driving = value;
        }
    }

    public float Stamina
    {
        get
        {
            return stamina + Strength;
        }

        set
        {
            stamina = value;
        }
    }

    public float Running
    {
        get
        {
            return running + Agility;
        }

        set
        {
            running = value;
        }
    }

    public float Treatment
    {
        get
        {
            return treatment + (Intelligence + Agility) / 2; ;
        }

        set
        {
            treatment = value;
        }
    }

    public float Science
    {
        get
        {
            return science + Intelligence;
        }

        set
        {
            science = value;
        }
    }

    public float Crafting
    {
        get
        {
            return crafting + (Strength + Intelligence) / 2;
        }

        set
        {
            crafting = value;
        }
    }

    public float Leadership
    {
        get
        {
            return leadership + Charisma;
        }

        set
        {
            leadership = value;
        }
    }

    public float PrisonManagement
    {
        get
        {
            return prisonManagement + (Strength + Charisma) / 2;
        }

        set
        {
            prisonManagement = value;
        }
    }

    public float Lawmaking
    {
        get
        {
            return lawmaking + (Intelligence + Charisma) / 2;
        }

        set
        {
            lawmaking = value;
        }
    }

    public float Persuasion
    {
        get
        {
            return persuasion + Charisma;
        }

        set
        {
            persuasion = value;
        }
    }

    public float Intimidation
    {
        get
        {
            return intimidation + (Strength + Charisma) / 2;
        }

        set
        {
            intimidation = value;
        }
    }

    public float FacilityManagement
    {
        get
        {
            return facilityManagement + (Intelligence + Charisma) / 2; ;
        }

        set
        {
            facilityManagement = value;
        }
    }

    public float Herding
    {
        get
        {
            return herding + (Charisma + Agility) / 2;
        }

        set
        {
            herding = value;
        }
    }

    float? GetAbility(string abilityName)
    {
        FieldInfo field = GetType().GetField(abilityName, BindingFlags.IgnoreCase);
        if (field != null) return (float)field.GetValue(this);
        else return null;
    }
}
