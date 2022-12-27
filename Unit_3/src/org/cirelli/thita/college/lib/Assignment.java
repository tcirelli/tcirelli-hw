package org.cirelli.thita.college.lib;

import java.util.ArrayList;

public class Assignment implements IAssignment{
    private ArrayList<ISection> sections;
    private int number = 0;
    private String part = "";

    public Assignment(int n, String p) {
        sections = new ArrayList<ISection>();
        number = n;
        part = p;
    }

   public void run() {
        for (ISection s : sections) {
            s.run();
            System.out.println(s.toString());
        }
    }

    public void addSection(ISection s){
        sections.add(s);
    }

    public int getNumber() {
        return number;
    }

    public String getPart() {
        return part;
    }

    @Override
    public String toString() {
        return "Assignment " + getNumber() + ", Part " + getPart() + ", ";
    }
}