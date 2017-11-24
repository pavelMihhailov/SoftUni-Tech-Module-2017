<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_6331f6f0b8c0093856888052146dd3fefc7cb56865a3ba7da2377e70553289ae extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@Twig/layout.html.twig", "@Twig/Exception/exception_full.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@Twig/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_c59f73957047245a2c6fd129cc6a1cf21d0e51473451dc4c90e9c5e2b3cb4b0e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c59f73957047245a2c6fd129cc6a1cf21d0e51473451dc4c90e9c5e2b3cb4b0e->enter($__internal_c59f73957047245a2c6fd129cc6a1cf21d0e51473451dc4c90e9c5e2b3cb4b0e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_c59f73957047245a2c6fd129cc6a1cf21d0e51473451dc4c90e9c5e2b3cb4b0e->leave($__internal_c59f73957047245a2c6fd129cc6a1cf21d0e51473451dc4c90e9c5e2b3cb4b0e_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_5f5f4e80867d42a0c3e319a18696abf24d258ac05992d85597ff21c47f8c0bca = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5f5f4e80867d42a0c3e319a18696abf24d258ac05992d85597ff21c47f8c0bca->enter($__internal_5f5f4e80867d42a0c3e319a18696abf24d258ac05992d85597ff21c47f8c0bca_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <link href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpFoundationExtension')->generateAbsoluteUrl($this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("bundles/framework/css/exception.css")), "html", null, true);
        echo "\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
";
        
        $__internal_5f5f4e80867d42a0c3e319a18696abf24d258ac05992d85597ff21c47f8c0bca->leave($__internal_5f5f4e80867d42a0c3e319a18696abf24d258ac05992d85597ff21c47f8c0bca_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_0bb47e3bdf520b39429c753bb68c9ec50257becb85f25354f6056bda19035117 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_0bb47e3bdf520b39429c753bb68c9ec50257becb85f25354f6056bda19035117->enter($__internal_0bb47e3bdf520b39429c753bb68c9ec50257becb85f25354f6056bda19035117_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 8
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["exception"]) ? $context["exception"] : $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, (isset($context["status_code"]) ? $context["status_code"] : $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, (isset($context["status_text"]) ? $context["status_text"] : $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_0bb47e3bdf520b39429c753bb68c9ec50257becb85f25354f6056bda19035117->leave($__internal_0bb47e3bdf520b39429c753bb68c9ec50257becb85f25354f6056bda19035117_prof);

    }

    // line 11
    public function block_body($context, array $blocks = array())
    {
        $__internal_2109d3c215beb275191758e4a26dc83fe3c84d4e74d63e29233c3c9546096089 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_2109d3c215beb275191758e4a26dc83fe3c84d4e74d63e29233c3c9546096089->enter($__internal_2109d3c215beb275191758e4a26dc83fe3c84d4e74d63e29233c3c9546096089_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 12
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 12)->display($context);
        
        $__internal_2109d3c215beb275191758e4a26dc83fe3c84d4e74d63e29233c3c9546096089->leave($__internal_2109d3c215beb275191758e4a26dc83fe3c84d4e74d63e29233c3c9546096089_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/Exception/exception_full.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  78 => 12,  72 => 11,  58 => 8,  52 => 7,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <link href=\"{{ absolute_url(asset('bundles/framework/css/exception.css')) }}\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
";
    }
}
